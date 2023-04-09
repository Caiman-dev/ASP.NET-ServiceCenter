using System;
using ASP.NET_ServiceCenter.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ASP.NET_ServiceCenter.Areas.Identity.IdentityHostingStartup))]
namespace ASP.NET_ServiceCenter.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            // добавление контекста БД в проект
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<ApplicationDBContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("ApplicationDBContextConnection")));

            //    services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<ApplicationDBContext>();
            //});
        }
    }
}