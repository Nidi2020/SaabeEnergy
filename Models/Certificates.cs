using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class Certificates
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Title { get; set; }

        [StringLength(500)]
        [Display(Name = "نصویر")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Picture { get; set; }

        [StringLength(50)]
        [Display(Name = "سال دریافت")]
        public string RecieveDate { get; set; }

        [Display(Name = "ترتیب نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public int ShowOrder { get; set; }

        [Display(Name = "وضعیت نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public byte Status { get; set; } = (byte)AllEnums.Tables.Status.Show;

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";
    }
}
