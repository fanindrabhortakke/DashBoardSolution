using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashboardSolution.Startup))]
namespace DashboardSolution
{
    public partial class Startup
    { 
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
