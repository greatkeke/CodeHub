using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDemoUI.Startup))]
namespace MVCDemoUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
