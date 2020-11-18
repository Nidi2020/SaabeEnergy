using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services.Interfaces;
using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services
{
    public class CertificatesService : ICertificatesService
    {
        private SaabenergyDbContext _context;
        public CertificatesService(SaabenergyDbContext context)
        {
            _context = context;
        }
        public List<CertificateViewModel> GetAllCertificates()
        {
            return _context.Certificates.OrderByDescending(p => p.ShowOrder).Select(p => new CertificateViewModel()
            {
                Title = p.Title,
                Picture = p.Picture,

            }).ToList();
        }

    }
}
