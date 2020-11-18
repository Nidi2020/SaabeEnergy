using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class ProductService : IProductService
    {
        private SaabenergyDbContext _context;
        public ProductService(SaabenergyDbContext context)
        {
            _context = context;
        }



        public List<ProductGroupListViewModel> GetAllProductGroup()
        {
            return _context.ProductGroups.OrderByDescending(p => p.ShowOrder).Select(p => new ProductGroupListViewModel()
            {
                Id = p.Id,
                Title = p.Title,

            }).ToList();
        }
        public List<ProductListViewModel> GetAllProductsByGroupId(int id)
        {
            return _context.Products.Where(p => p.ProductGroupId == id).OrderByDescending(p => p.ShowOrder).Select(p => new ProductListViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Picture = p.Picture

            }).ToList();
        }

        public ProductDetailViewModel GetProduct(int id)
        {
            var query = _context.Products.Find(id);
            return new ProductDetailViewModel()
            {
                Id = query.Id,
                Title = query.Title,
                Picture = query.Picture,
                Description = query.Description,
                ProductGroupId = query.ProductGroupId,
                ProductGroupTitle = _context.ProductGroups.Find(query.ProductGroupId).Title,
            };
        }

        public ProductGroupListViewModel GetProductGroup(int id)
        {
            var query = _context.ProductGroups.Find(id);
            return new ProductGroupListViewModel()
            {
                Id = query.Id,
                Title = query.Title,
            };
        }

        public List<ProductListViewModel> GetAllNewProducts()
        {
            return _context.Products.Where(p => p.IsNewest == true).OrderByDescending(p => p.ShowOrder).ThenByDescending(p => p.Id).Select(p => new ProductListViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Picture = p.Picture

            }).Take(8).ToList();
        }
    }
}
