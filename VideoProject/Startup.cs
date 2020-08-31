using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoProject.Startup))]
namespace VideoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
