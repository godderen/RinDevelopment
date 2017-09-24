using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RinDevelopment.Startup))]
namespace RinDevelopment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
