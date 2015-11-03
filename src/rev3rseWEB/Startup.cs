using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rev3rseWEB.Startup))]
namespace rev3rseWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
