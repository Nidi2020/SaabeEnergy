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
using Microsoft.AspNetCore.Routing;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;

namespace SaabeEnergy_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("GetCutomersList")]
        public ServiceResult<List<CutomerViewModel>> GetCutomersList()
        {
            var retVal = new ServiceResult<List<CutomerViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";
 
            retVal.Success = 1;
            retVal.Results = _customerService.GetCustomersList((byte)AllEnums.Customer.Type.Customer);
            return retVal;
        }

        [HttpGet]
        [Route("GetCooperationsList")]
        public ServiceResult<List<CutomerViewModel>> GetCooperationsList()
        {
            var retVal = new ServiceResult<List<CutomerViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";
             
            retVal.Success = 1;
            retVal.Results = _customerService.GetCustomersList((byte)AllEnums.Customer.Type.Cooperation);
            return retVal;
        }

        [HttpGet]
        [Route("Image/{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/customers/" + imageName))
            {
                var image = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "/wwwroot/images/customers/" + imageName);
                response.Content = new StreamContent(image);

                return File(image, "image/jpg");
            }

            return NotFound();
        }
    }
}
