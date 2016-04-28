using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(miSitioWeb.Startup))]
namespace miSitioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
