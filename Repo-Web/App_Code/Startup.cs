using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo_Web.Startup))]
namespace Repo_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
