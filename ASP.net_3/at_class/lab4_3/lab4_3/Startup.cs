using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4_3.Startup))]
namespace lab4_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
