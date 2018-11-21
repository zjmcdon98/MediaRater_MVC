using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaRater_MVC.Startup))]
namespace MediaRater_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
