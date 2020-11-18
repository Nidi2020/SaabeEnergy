using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Models.Utility;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class ArticlesService : IArticlesService
    {
        private SaabenergyDbContext _context;
        public ArticlesService(SaabenergyDbContext context)
        {
            _context = context;
        }
        public List<ArticleGroupListViewModel> GetAllArticleGroup()
        {
            return _context.ArticleGroups.OrderByDescending(p => p.ShowOrder).Select(p => new ArticleGroupListViewModel()
            {
                Id = p.Id,
                Title = p.Title,

            }).ToList();
        }

        public List<ArticleListViewModel> GetAllArticlesByGroupId(int id)
        {
            return _context.Articles.Where(p => p.ArticleGroupId == id).OrderByDescending(p => p.ShowOrder).ThenByDescending(p => p.Id).Select(p => new ArticleListViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Date = p.DateX.ToShortPersian(),

            }).ToList();
        }

        public List<ArticleListViewModel> GetAllNewArticles()
        {
            return _context.Articles.Where(p => p.IsNewest == true).OrderByDescending(p => p.ShowOrder).ThenByDescending(p => p.Id).Select(p => new ArticleListViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Date = p.DateX.ToShortPersian(),

            }).Take(10).ToList();
        }

        public ArticleDetailViewModel GetArticle(int id)
        {
            var query = _context.Articles.Find(id);
            return new ArticleDetailViewModel()
            {
                Id = query.Id,
                Title = query.Title,
                Picture = query.Picture,
                Description = query.Description,
                Date = query.DateX.ToShortPersian(),
                ArticleGroupId = query.ArticleGroupId,
                ArticleGroupTitle = _context.ArticleGroups.Find(query.ArticleGroupId).Title,
            };
        }

        public ArticleGroupListViewModel GetArticleGroup(int id)
        {
            var query = _context.ArticleGroups.Find(id);
            return new ArticleGroupListViewModel()
            {
                Id = query.Id,
                Title = query.Title,
            };
        }
    }
}
