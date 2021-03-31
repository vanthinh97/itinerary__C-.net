using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab6_1.Startup))]
namespace lab6_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
