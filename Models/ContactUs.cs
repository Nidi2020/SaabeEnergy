using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Title { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [StringLength(50)]
        [Display(Name = "تلفن")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Display(Name = "موبایل")]
        public string Mobile { get; set; }

        [StringLength(50)]
        [Display(Name = "فکس")]
        public string Fax { get; set; }

        [StringLength(500)]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [StringLength(500)]
        [Display(Name = "وب سایت")]
        public string WebSite { get; set; }

        [StringLength(500)]
        public string GoogleMapX { get; set; }

        [StringLength(500)]
        public string GoogleMapY { get; set; }

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";

    }
}
