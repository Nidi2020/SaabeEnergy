using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class ContactUsService : IContactUsService
    {
        private SaabenergyDbContext _context;
        public ContactUsService(SaabenergyDbContext context)
        {
            _context = context;
        }

        public ContactUs GetConatctUs()
        {
            return _context.ContactUs.Find(1);
        }
    }
}
