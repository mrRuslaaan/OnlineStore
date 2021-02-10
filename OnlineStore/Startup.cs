using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Infrastructure.Services.InDatabase;
using OnlineStore.Data.Database.Context;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Database;
using OnlineStore.Infrastructure.Services.InMemory;

namespace OnlineStore
{
    public class Startup
    {
        private readonly IConfiguration _Configuration;
        public Startup(IConfiguration Configuration) => _Configuration = Configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OnlineStoreDB>(opt => opt.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<OnlineStoreDBInitializer>();

            services
                .AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddTransient<IWorkers, IWorkerService>();
            services.AddTransient<IBlog, IBlogService>();
            services.AddTransient<IProduct, IProductServicseDB>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, OnlineStoreDBInitializer db)
        {
            db.Initialize();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Catalog}/{action=Index}/{id?}");
            });
        }
    }
}
