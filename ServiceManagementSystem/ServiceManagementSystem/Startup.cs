using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceManagementSystem.Startup))]
namespace ServiceManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
