using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NatyNew.Startup))]
namespace NatyNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
