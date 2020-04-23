using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(hamavuri.identityserver.api.Areas.Identity.IdentityHostingStartup))]
namespace hamavuri.identityserver.api.Areas.Identity
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