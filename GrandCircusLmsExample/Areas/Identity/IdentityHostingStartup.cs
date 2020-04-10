using System;
using GrandCircusLmsExample.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GrandCircusLmsExample.Areas.Identity.IdentityHostingStartup))]
namespace GrandCircusLmsExample.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GCLmsIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GCLmsIdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<GCLmsIdentityContext>();
            });
        }
    }
}