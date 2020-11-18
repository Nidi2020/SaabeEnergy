using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "گروه مقالات")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public int ArticleGroupId { get; set; }

        [StringLength(200)]
        [Display(Name = "نام مقاله")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Title { get; set; }

        [StringLength(80)]
        [Required]
        public string PageTitle { get; set; }

        [StringLength(500)]
        public string PageDescription { get; set; }

        [StringLength(200)]
        public string PageDCSubject { get; set; }

        [StringLength(500)]
        public string Picture { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Display(Name = "تاریخ انتشار")]
        public DateTime DateX { get; set; }

        [Display(Name = "ترتیب نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public int ShowOrder { get; set; }

        [Display(Name = "نمایش در صفحه اصلی")]
        [DefaultValue(false)]
        public bool IsNewest { get; set; }

        [Display(Name = "وضعیت نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        [DefaultValue((byte)AllEnums.Tables.Status.Show)]
        public byte Status { get; set; }

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";

        public virtual ArticleGroups ArticleGroup { get; set; }

    }
}
