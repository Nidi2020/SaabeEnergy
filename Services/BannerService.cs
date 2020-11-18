using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class BannerService : IBannerService
    {
        private SaabenergyDbContext _context;
        public BannerService(SaabenergyDbContext context)
        {
            _context = context;
        }

        public List<BannerViewModel> GetBanner()
        {
            return _context.Banner.Where(p => p.Position == (byte)AllEnums.Banner.Position.MainPage).OrderByDescending(p => p.ShowOrder).Select(p => new BannerViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Picture = p.Picture,

            }).ToList();
        }
    }
}
