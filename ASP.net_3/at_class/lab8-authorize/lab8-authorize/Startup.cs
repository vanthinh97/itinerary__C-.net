using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab8_authorize.Startup))]
namespace lab8_authorize
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
