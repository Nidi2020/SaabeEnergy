using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class ServiceUsService : IServiceUsService
    {
        private SaabenergyDbContext _context;
        public ServiceUsService(SaabenergyDbContext context)
        {
            _context = context;
        }
        public List<ServiceViewModel> GetServices()
        {
            return _context.ServiceUs.OrderByDescending(p => p.ShowOrder).ThenByDescending(p => p.Id).Select(p => new ServiceViewModel()
            {
                Title = p.Title,
                Picture = p.Picture,
                Description = p.Description,

            }).ToList();
        }

        public List<HomePageServiceViewModel> GetHomePageServices()
        {
            return _context.ServiceUs.Where(p => p.IsNewest == true).OrderByDescending(p => p.ShowOrder).ThenByDescending(p => p.Id).Select(p => new HomePageServiceViewModel()
            {
                Title = p.Title,
                ClassName = p.ClassName,
                Description = p.Description,

            }).ToList();
        }
    }
}
