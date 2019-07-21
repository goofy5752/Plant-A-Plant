using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Plant_A_Plant.Web.Areas.Identity.IdentityHostingStartup))]
namespace Plant_A_Plant.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}