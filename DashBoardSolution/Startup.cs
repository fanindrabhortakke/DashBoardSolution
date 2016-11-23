using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashBoardSolution.Startup))]
namespace DashBoardSolution
{
    public partial class Startup
    { 
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
