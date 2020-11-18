using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500)]
        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Name { get; set; }

        [StringLength(200)]
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name = "تلفن")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Phone { get; set; }

        
        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Description { get; set; }

        [Display(Name = "وضعیت فرم")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public byte Status { get; set; } = (byte)AllEnums.CheckStatus.Status.Hide;

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";
    }
}
