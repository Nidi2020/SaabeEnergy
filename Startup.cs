using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SaabeEnergy_backend.Models;
using SaabeEnergy_backend.Services;
using SaabeEnergy_backend.Services.Interfaces;

namespace SaabeEnergy_backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("Corse", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            services.AddDbContext<SaabenergyDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CSConnectionString")));

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            })
          .AddEntityFrameworkStores<SaabenergyDbContext>()
          .AddDefaultTokenProviders();

            #region IoC

            services.AddTransient<ICmsPageService, CmsPageService>();
            services.AddTransient<ICertificatesService, CertificatesService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IServiceUsService, ServiceUsService>();
            services.AddTransient<IContactUsService, ContactUsService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IArticlesService, ArticlesService>();
            services.AddTransient<IBannerService, BannerService>();

            #endregion


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCors("Corse");
            app.UseMvc();
           
        }
    }
}
