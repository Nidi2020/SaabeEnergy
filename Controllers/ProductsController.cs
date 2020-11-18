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
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("ProductGroupList")]
        public ServiceResult<List<ProductGroupListViewModel>> ProductGroupList()
        {
            var retVal = new ServiceResult<List<ProductGroupListViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _productService.GetAllProductGroup();
            return retVal;
        }

        [HttpGet]
        [Route("ProductGroup/{id}")]
        public ServiceResult<ProductGroupListViewModel> ProductGroup(int id)
        {
            var retVal = new ServiceResult<ProductGroupListViewModel>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _productService.GetProductGroup(id);
            return retVal;
        }

        [HttpGet]
        [Route("ProductList/{id}")]
        public ServiceResult<List<ProductListViewModel>> ProductList(int id)
        {
            var retVal = new ServiceResult<List<ProductListViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _productService.GetAllProductsByGroupId(id);
            return retVal;
        }

        [HttpGet]
        [Route("ProductDetail/{id}")]
        public ServiceResult<ProductDetailViewModel> ProductDetail(int id)
        {
            var retVal = new ServiceResult<ProductDetailViewModel>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _productService.GetProduct(id);
            return retVal;
        }

        [HttpGet]
        [Route("ProductNewList")]
        public ServiceResult<List<ProductListViewModel>> ProductNewList()
        {
            var retVal = new ServiceResult<List<ProductListViewModel>>();
            retVal.Success = 0;
            retVal.Dev_message = "";
            retVal.User_message = "";

            retVal.Success = 1;
            retVal.Results = _productService.GetAllNewProducts();
            return retVal;
        }


        [HttpGet]
        [Route("Image/{imageName}")]
        [AllowAnonymous]
        public IActionResult GetImage(string imageName)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "/wwwroot/images/products/" + imageName))
            {
                var image = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "/wwwroot/images/products/" + imageName);
                response.Content = new StreamContent(image);

                return File(image, "image/jpg");
            }

            return NotFound();
        }


    }
}
