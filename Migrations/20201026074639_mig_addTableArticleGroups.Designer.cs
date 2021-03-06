﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaabeEnergy_backend.Models;

namespace SaabeEnergy_backend.Migrations
{
    [DbContext(typeof(SaabenergyDbContext))]
    [Migration("20201026074639_mig_addTableArticleGroups")]
    partial class mig_addTableArticleGroups
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateX");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<byte>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ArticleGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PageDCSubject")
                        .HasMaxLength(200);

                    b.Property<string>("PageDescription")
                        .HasMaxLength(500);

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int?>("ParentId");

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<int>("ShowOrder");

                    b.Property<byte>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ArticleGroups");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.Certificates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("RecieveDate")
                        .HasMaxLength(50);

                    b.Property<int>("ShowOrder");

                    b.Property<byte>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.CmsPages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<string>("PageDCSubject")
                        .HasMaxLength(200);

                    b.Property<string>("PageDescription")
                        .HasMaxLength(500);

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int?>("ParentId");

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<int>("ShowOrder");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("URL")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("CmsPages");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte>("Status");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Email")
                        .HasMaxLength(500);

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<string>("GoogleMapX")
                        .HasMaxLength(500);

                    b.Property<string>("GoogleMapY")
                        .HasMaxLength(500);

                    b.Property<string>("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("WebSite")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<int>("ShowOrder");

                    b.Property<byte>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<byte>("Type");

                    b.Property<string>("URL")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ProductGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PageDCSubject")
                        .HasMaxLength(200);

                    b.Property<string>("PageDescription")
                        .HasMaxLength(500);

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int?>("ParentId");

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<int>("ShowOrder");

                    b.Property<byte>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductGroups");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsNewest");

                    b.Property<string>("PageDCSubject")
                        .HasMaxLength(200);

                    b.Property<string>("PageDescription")
                        .HasMaxLength(500);

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<int>("ProductGroupId");

                    b.Property<int>("ShowOrder");

                    b.Property<byte>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ProductGroupId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ServiceUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasMaxLength(500);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<bool>("IsNewest");

                    b.Property<string>("Logo")
                        .HasMaxLength(500);

                    b.Property<string>("Picture")
                        .HasMaxLength(500);

                    b.Property<int>("ShowOrder");

                    b.Property<byte>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("ServiceUs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaabeEnergy_backend.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ArticleGroups", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ArticleGroups", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.CmsPages", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.CmsPages", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.ProductGroups", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ProductGroups", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SaabeEnergy_backend.Models.Products", b =>
                {
                    b.HasOne("SaabeEnergy_backend.Models.ProductGroups", "ProductGroup")
                        .WithMany("Products")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
