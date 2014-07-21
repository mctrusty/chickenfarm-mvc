using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChickenFarmMVC.Startup))]
namespace ChickenFarmMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
