using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SImpleTwoPager.Startup))]
namespace SImpleTwoPager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
