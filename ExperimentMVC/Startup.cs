using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperimentMVC.Startup))]
namespace ExperimentMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
