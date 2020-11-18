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
    public class PagesController : ControllerBase
    {
        private ICmsPageService _cmspageService;
        private IBannerService _bannerService;
        public PagesController(ICmsPageService cmspageService, IBannerService bannerService)
        {
            _cmspageService = cmspageService;
            _bannerService = bannerService;
        }

        [HttpGet]
        [Route("GetPage/{url}")]
        public ServiceResult<CmsPageViewModel> GetPage(string url)
        {
            var retVal = new ServiceResult<CmsPageViewModel>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            if (url == null || url == "")
            {
                retVal.Dev_message = "چنین صفحه ای بافت نشد.";
                return retVal;
            }

            retVal.Success = 1;
            retVal.Results = _cmspageService.GetCmsPageURL(url);
            return retVal;

        }

        [HttpGet]
        [Route("GetHomePageBanner")]
        public ServiceResult<List<BannerViewModel>> GetHomePageBanner()
        {
            var retVal = new ServiceResult<List<BannerViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _bannerService.GetBanner();
            return retVal;

        }

        [HttpGet]
        [Route("Image/{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/banner/" + imageName))
            {
                var image = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "/wwwroot/images/banner/" + imageName);
                response.Content = new StreamContent(image);

                return File(image, "image/jpg");
            }

            return NotFound();
        }

    }
}
