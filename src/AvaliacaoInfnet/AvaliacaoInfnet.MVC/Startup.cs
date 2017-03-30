using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AvaliacaoInfnet.MVC.Startup))]
namespace AvaliacaoInfnet.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
