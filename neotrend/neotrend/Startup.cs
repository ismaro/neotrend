using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(neotrend.Startup))]
namespace neotrend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
