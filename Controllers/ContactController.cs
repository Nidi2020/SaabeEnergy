using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;

namespace SaabeEnergy_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactUsService _contactUsService;
        private IContactService _contactService;
        public ContactController(IContactUsService contactUsService, IContactService contactService)
        {
            _contactUsService = contactUsService;
            _contactService = contactService;
        }


        [HttpGet]
        public ServiceResult<ContactUs> Get()
        {
            var retVal = new ServiceResult<ContactUs>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

          
            retVal.Success = 1;
            retVal.Results = _contactUsService.GetConatctUs();
            return retVal;
        }

        [HttpPost]
        public ServiceResult<string> Post(ConatctViewModel model)
        {
            var retVal = new ServiceResult<string>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            if (!ModelState.IsValid)
            {
                retVal.User_message = "اطلاعات ورودی اشتباه هست";
                return retVal;
            }

            retVal.Success = 1;
            _contactService.Add(model);
            retVal.User_message = "عملیات ثبت اطلاعات با موفقیت انجام شد.";
            return retVal;
        }
    }
}
