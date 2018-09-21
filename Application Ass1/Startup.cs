using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application_Ass1.Startup))]
namespace Application_Ass1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
