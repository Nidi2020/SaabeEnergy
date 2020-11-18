using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.ViewModel
{
    public class ArticleGroupListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class ArticleListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }

    }
    public class ArticleDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int ArticleGroupId { get; set; }
        public string ArticleGroupTitle { get; set; }


    }
}
