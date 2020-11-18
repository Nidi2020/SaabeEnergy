using SaabeEnergy_backend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Services.Interfaces
{
    public interface ICustomerService
    {
        List<CutomerViewModel> GetCustomersList(byte type);
    }
}
