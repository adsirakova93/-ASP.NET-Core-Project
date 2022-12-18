using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TheBookClub.Areas.Identity.IdentityHostingStartup))]
namespace TheBookClub.Areas.Identity
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