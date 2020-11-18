using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class CmsPages
    {
        [Key]
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(500)]
        [Display(Name = "آدرس صفحه")]
        public string URL { get; set; }

        [StringLength(80)]
        [Required]
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

        [Display(Name = "ترتیب نمایش")]
        [Required(ErrorMessage = "ترتیب نمایش را وارد نمایید")]
        public int ShowOrder { get; set; }

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";

        public virtual CmsPages Parent { get; set; }

    }
}
