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
using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;

namespace SaabeEnergy_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        private ICertificatesService _certificatesService;
        public CertificatesController(ICertificatesService certificatesService)
        {
            _certificatesService = certificatesService;
        }
        [HttpGet]
        public ServiceResult<List<CertificateViewModel>> Get()
        {
            var retVal = new ServiceResult<List<CertificateViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            //if (url == null || url == "")
            //{
            //    retVal.Dev_message = "چنین صفحه ای بافت نشد.";
            //    return retVal;
            //}

            retVal.Success = 1;
            retVal.Results = _certificatesService.GetAllCertificates();
            return retVal;
        }

        [HttpGet]
        [Route("Image/{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/certificates/" + imageName))
            {
                var image = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "/wwwroot/images/certificates/" + imageName);
                response.Content = new StreamContent(image);

                return File(image, "image/jpg");
            }

            return NotFound();
        }
    }
}
