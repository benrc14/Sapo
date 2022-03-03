using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Sapo.Models;
using Microsoft.AspNetCore.Http;

namespace Sapo
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
        services.AddControllersWithViews();
        services.AddDbContext<BookstoreContext>(options =>
            options.UseSqlite(Configuration["ConnectionStrings:SapoDBConnection"])
            );

        services.AddScoped<ISapoRepository, EFSapoRepository>();
        services.AddScoped<IPurchaseRepository, EFPurchaseRepository>();

        services.AddRazorPages();

        services.AddDistributedMemoryCache();
        services.AddSession();

        services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        // Cooresponds with wwwroot
        app.UseStaticFiles();

        app.UseSession();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("typepage",
                "{category}/Page{pageNum}",
                new { Controller = "Home", action = "index" });

            endpoints.MapControllerRoute(
                name: "Paging",
                pattern: "Page{pageNum}",
                defaults: new { Controller = "Home", action = "index", pageNum = 1 });

            endpoints.MapControllerRoute("type",
                "{category}",
                new { Controller = "Home", action = "index", pageNum = 1 });



            endpoints.MapDefaultControllerRoute();

            endpoints.MapRazorPages();


        });
    }
}
}
