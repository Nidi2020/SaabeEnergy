using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class ServiceUs
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Title { get; set; }

        [StringLength(500)]
        [Display(Name = "تصویر")]
        public string Picture { get; set; }

        [StringLength(500)]
        [Display(Name = "لوگو")]
        public string Logo { get; set; }

        [StringLength(500)]
        [Display(Name = "کلاس لوگو")]
        public string ClassName { get; set; }

        [StringLength(2000)]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "نمایش در صفحه اصلی")]
        [DefaultValue(0)]
        public bool IsNewest { get; set; }

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
