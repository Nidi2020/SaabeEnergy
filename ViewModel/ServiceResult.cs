using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.ViewModel
{
    public class ServiceResult<T>
    {
        public int Success { get; set; }
        public string Dev_message { get; set; }
        public string User_message { get; set; }
        public T Results { get; set; }

    }
}
