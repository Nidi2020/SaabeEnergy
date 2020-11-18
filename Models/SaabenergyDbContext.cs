using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace SaabeEnergy_backend.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser() { }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string LastName { get; set; }

        [Display(Name = "نوع کاربر")]
        public byte UserType { get; set; }

        [Display(Name = "تصویر کاربر")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Picture { get; set; }

        [Display(Name = "موبایل کاربر")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Mobile { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }

        public DateTime DateX { get; set; } = DateTime.Now;
    }
    public class ApplicationRole : IdentityRole<int>
    {

    }
    public class ApplicationClaims : IdentityUserClaim<int>
    {

    }
    public class SaabenergyDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public SaabenergyDbContext(DbContextOptions<SaabenergyDbContext> options) : base(options)
        {
        }

        public DbSet<CmsPages> CmsPages { get; set; }
        public DbSet<Certificates> Certificates { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<ServiceUs> ServiceUs { get; set; }

        public DbSet<ProductGroups> ProductGroups { get; set; }
        public DbSet<Products> Products { get; set; }

        public DbSet<ArticleGroups> ArticleGroups { get; set; }
        public DbSet<Articles> Articles { get; set; }

        public DbSet<Banner> Banner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasQueryFilter(p => p.IsDeleted == false);
            modelBuilder.Entity<Certificates>().HasQueryFilter(p => p.Status == (byte)AllEnums.Tables.Status.Show && p.Culture == "fa-IR");
            modelBuilder.Entity<Customers>().HasQueryFilter(p => p.Status == (byte)AllEnums.Tables.Status.Show && p.Culture == "fa-IR");
            modelBuilder.Entity<ServiceUs>().HasQueryFilter(p => p.Status == (byte)AllEnums.Tables.Status.Show && p.Culture == "fa-IR");
            modelBuilder.Entity<ContactUs>().HasQueryFilter(p => p.Culture == "fa-IR");
            modelBuilder.Entity<Contact>().HasQueryFilter(p => p.Culture == "fa-IR");
            modelBuilder.Entity<ProductGroups>().HasQueryFilter(p => p.Status == (byte)AllEnums.Tables.Status.Show && p.IsDeleted == false && p.Culture == "fa-IR");
            modelBuilder.Entity<Products>().HasQueryFilter(p => p.Status == (byte)AllEnums.Tables.Status.Show && p.IsDeleted == false && p.Culture == "fa-IR");
            modelBuilder.Entity<ArticleGroups>().HasQueryFilter(p => p.Status == (byte)AllEnums.Tables.Status.Show && p.IsDeleted == false && p.Culture == "fa-IR");
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
