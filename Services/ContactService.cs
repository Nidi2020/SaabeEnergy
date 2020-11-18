using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class ContactService : IContactService
    {
        private SaabenergyDbContext _context;
        public ContactService(SaabenergyDbContext context)
        {
            _context = context;
        }
        public void Add(ConatctViewModel model)
        {
            var item = new Contact()
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Description = model.Text,
            };
            _context.Add(item);
            _context.SaveChanges();
        }
    }
}
