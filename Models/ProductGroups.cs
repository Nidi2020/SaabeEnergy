using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class ProductGroups
    {
        public ProductGroups()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(200)]
        [Display(Name = "نام گروه محصولات")]
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

        public bool IsDeleted { get; set; } = false;

        [Display(Name = "ترتیب نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public int ShowOrder { get; set; }

        [Display(Name = "وضعیت نمایش")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public byte Status { get; set; } = (byte)AllEnums.Tables.Status.Show;

        [Required]
        [StringLength(5)]
        public string Culture { get; set; } = "fa-IR";

        public virtual ProductGroups Parent { get; set; }

        public virtual ICollection<Products> Products { get; set; }

    }
}
