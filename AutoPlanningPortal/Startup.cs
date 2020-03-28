using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoPlanningPortal.Startup))]
namespace AutoPlanningPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
