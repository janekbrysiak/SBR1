using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBR1.Startup))]
namespace SBR1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
