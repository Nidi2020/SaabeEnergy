using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.ViewModel
{
    public class ProductGroupListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }

    }

    public class ProductDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int ProductGroupId { get; set; }
        public string ProductGroupTitle { get; set; }


    }
}
