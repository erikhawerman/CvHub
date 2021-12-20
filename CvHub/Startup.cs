using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CvHub.Startup))]
namespace CvHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
