using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
 

        [StringLength(200)]
        [Display(Name = "عنوان بنر")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Title { get; set; }


        [StringLength(500)]
        public string Picture { get; set; }


        [Display(Name = "جایگاه")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        [DefaultValue((byte)AllEnums.Banner.Position.MainPage)]
        public byte Position { get; set; }

        [Display(Name = "نوع صفحه")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        [DefaultValue((byte)AllEnums.Banner.PageType.Current)]
        public byte PageType { get; set; }

        [Display(Name = "نوع فایل")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        [DefaultValue((byte)AllEnums.Banner.FileType.Pic)]
        public byte FileType { get; set; }


        [StringLength(80)]
        public string PageTitle { get; set; }

        [StringLength(500)]
        public string PageDescription { get; set; }

        [StringLength(200)]
        public string PageDCSubject { get; set; }     

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime DateX { get; set; }

        [Display(Name = "ترتیب نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public int ShowOrder { get; set; }

        [Display(Name = "وضعیت نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        [DefaultValue((byte)AllEnums.Tables.Status.Show)]
        public byte Status { get; set; }

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";

       

    }
}
