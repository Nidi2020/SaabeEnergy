using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;

namespace SaabeEnergy_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private IServiceUsService _serviceUsService;
        public ServicesController(IServiceUsService serviceUsService)
        {
            _serviceUsService = serviceUsService;
        }

        [HttpGet]
        public ServiceResult<List<ServiceViewModel>> Get()
        {
            var retVal = new ServiceResult<List<ServiceViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _serviceUsService.GetServices();
            return retVal;
        }

        [HttpGet]
        [Route("HomePageServices")]
        public ServiceResult<List<HomePageServiceViewModel>> GetHomePageServices()
        {
            var retVal = new ServiceResult<List<HomePageServiceViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _serviceUsService.GetHomePageServices();
            return retVal;
        }



        [HttpGet]
        [Route("Image/{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/services/" + imageName))
            {
                var image = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "/wwwroot/images/services/" + imageName);
                response.Content = new StreamContent(image);

                return File(image, "image/jpg");
            }

            return NotFound();
        }
    }
}
