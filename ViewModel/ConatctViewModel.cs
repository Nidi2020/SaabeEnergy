using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.ViewModel
{
    public class ConatctViewModel
    {
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "پست الکترونیک نامعتبر است.")]
        [Display(Name = "پست الکترونیک")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Text { get; set; }
    }
}
