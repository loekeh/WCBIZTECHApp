using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCBIZTECHApp.Startup))]
namespace WCBIZTECHApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
