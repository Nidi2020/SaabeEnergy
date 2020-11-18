using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services.Interfaces
{
    public interface IProductService
    {
        List<ProductGroupListViewModel> GetAllProductGroup();
        List<ProductListViewModel> GetAllProductsByGroupId(int id);

        List<ProductListViewModel> GetAllNewProducts();

        ProductDetailViewModel GetProduct(int id);

        ProductGroupListViewModel GetProductGroup(int id);
    }
}
