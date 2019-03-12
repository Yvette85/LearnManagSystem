using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnManagSystem.Startup))]
namespace LearnManagSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
