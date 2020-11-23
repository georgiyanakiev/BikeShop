using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeShop.Web.Startup))]
namespace BikeShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
