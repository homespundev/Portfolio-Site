using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalSite.UI.Startup))]
namespace PersonalSite.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
