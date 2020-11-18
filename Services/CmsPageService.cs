using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class CmsPageService : ICmsPageService
    {
        private SaabenergyDbContext _context;
        public CmsPageService(SaabenergyDbContext context)
        {
            _context = context;
        }

        public CmsPageViewModel GetCmsPageURL(string url)
        {
            return _context.CmsPages.Where(p => p.URL.ToLower() == url.ToLower()).Select(p => new CmsPageViewModel()
            {
                Title = p.Title,
                HtmlBody = p.Description,
                PageTitle = p.PageTitle,
                PageDCSubject = p.PageDCSubject,
                PageDescription = p.PageDescription,

            }).FirstOrDefault();
        }
    }
}
