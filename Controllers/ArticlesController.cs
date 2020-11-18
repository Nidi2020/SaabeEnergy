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
    public class ArticlesController : ControllerBase
    {
        private IArticlesService _articlesService;
        public ArticlesController(IArticlesService articlesService)
        {
            _articlesService = articlesService;
        }

        [HttpGet]
        [Route("ArticleGroupList")]
        public ServiceResult<List<ArticleGroupListViewModel>> ArticleGroupList()
        {
            var retVal = new ServiceResult<List<ArticleGroupListViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _articlesService.GetAllArticleGroup();
            return retVal;
        }

        [HttpGet]
        [Route("ArticleGroup/{id}")]
        public ServiceResult<ArticleGroupListViewModel> ArticleGroup(int id)
        {
            var retVal = new ServiceResult<ArticleGroupListViewModel>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _articlesService.GetArticleGroup(id);
            return retVal;
        }

        [HttpGet]
        [Route("ArticleList/{id}")]
        public ServiceResult<List<ArticleListViewModel>> ArticleList(int id)
        {
            var retVal = new ServiceResult<List<ArticleListViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _articlesService.GetAllArticlesByGroupId(id);
            return retVal;
        }

        [HttpGet]
        [Route("ArticleDetail/{id}")]
        public ServiceResult<ArticleDetailViewModel> ArticleDetail(int id)
        {
            var retVal = new ServiceResult<ArticleDetailViewModel>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _articlesService.GetArticle(id);
            return retVal;
        }

        [HttpGet]
        [Route("ArticleListHomePage")]
        public ServiceResult<List<ArticleListViewModel>> ArticleListHomePage()
        {
            var retVal = new ServiceResult<List<ArticleListViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _articlesService.GetAllNewArticles();
            return retVal;
        }

        [HttpGet]
        [Route("Image/{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/articles/" + imageName))
            {
                var image = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "/wwwroot/images/articles/" + imageName);
                response.Content = new StreamContent(image);

                return File(image, "image/jpg");
            }

            return NotFound();
        }



    }
}
