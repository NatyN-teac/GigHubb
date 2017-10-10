using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMosicStore.Startup))]
namespace MvcMosicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
