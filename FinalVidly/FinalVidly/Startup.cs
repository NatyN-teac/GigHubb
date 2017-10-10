using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalVidly.Startup))]
namespace FinalVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
