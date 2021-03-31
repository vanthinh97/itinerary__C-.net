using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadWriteOfTeacher.Startup))]
namespace ReadWriteOfTeacher
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
