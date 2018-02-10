using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnicornHairSolution.Web.Startup))]
namespace UnicornHairSolution.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
