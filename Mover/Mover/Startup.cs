using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mover.Startup))]
namespace Mover
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
