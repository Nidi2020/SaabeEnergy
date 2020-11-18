using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.ViewModel
{
    public class ServiceViewModel
    {
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }

    public class HomePageServiceViewModel
    {
        public string Title { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
    }
}
