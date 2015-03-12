using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SubdomainRouteToArea.Startup))]
namespace SubdomainRouteToArea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
