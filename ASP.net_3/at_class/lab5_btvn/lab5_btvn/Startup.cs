using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab5_btvn.Startup))]
namespace lab5_btvn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
