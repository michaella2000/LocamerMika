using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocamerMsySite.Startup))]
namespace LocamerMsySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
