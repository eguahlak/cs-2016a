using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_MVC_Application.Startup))]
namespace ASP_MVC_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
