using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WTR.Startup))]
namespace WTR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
