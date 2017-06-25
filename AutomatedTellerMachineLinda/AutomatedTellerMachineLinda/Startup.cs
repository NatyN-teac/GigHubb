using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomatedTellerMachineLinda.Startup))]
namespace AutomatedTellerMachineLinda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
