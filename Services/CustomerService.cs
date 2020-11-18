using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class CustomerService : ICustomerService
    {
        private SaabenergyDbContext _context;
        public CustomerService(SaabenergyDbContext context)
        {
            _context = context;
        }

        public List<CutomerViewModel> GetCustomersList(byte type)
        {
            return _context.Customers.Where(p => p.Type == type).OrderByDescending(p => p.ShowOrder).ThenByDescending(p => p.Id)
                           .Select(p => new CutomerViewModel()
                           {
                               Title = p.Title,
                               Picture = p.Picture,
                               URL = p.URL,

                           }).ToList();
        }
    }
}
