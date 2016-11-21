using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite_2.Startup))]
namespace WebSite_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
