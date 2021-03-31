using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4_1.Startup))]
namespace lab4_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
