using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassWork2.Startup))]
namespace ClassWork2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
