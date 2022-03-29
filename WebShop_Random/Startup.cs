using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop_Random.Startup))]
namespace WebShop_Random
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
