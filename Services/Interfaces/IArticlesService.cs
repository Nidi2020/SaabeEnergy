using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services.Interfaces
{
    public interface IArticlesService
    {
        List<ArticleGroupListViewModel> GetAllArticleGroup();
        ArticleGroupListViewModel GetArticleGroup(int id);

        List<ArticleListViewModel> GetAllArticlesByGroupId(int id);

        ArticleDetailViewModel GetArticle(int id);

        List<ArticleListViewModel> GetAllNewArticles();
    }
}
