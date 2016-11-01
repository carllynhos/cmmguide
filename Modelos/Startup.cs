using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modelos.Startup))]
namespace Modelos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
