using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_WEB_Forms_Application.Startup))]
namespace ASP_WEB_Forms_Application
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
