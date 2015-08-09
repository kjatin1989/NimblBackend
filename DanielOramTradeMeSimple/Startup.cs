using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanielOramTradeMeSimple.Startup))]
namespace DanielOramTradeMeSimple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
