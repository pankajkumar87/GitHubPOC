using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubPOC.Startup))]
namespace GitHubPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
