using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4_2.Startup))]
namespace lab4_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
