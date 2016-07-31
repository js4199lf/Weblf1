using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Weblf1.Startup))]
namespace Weblf1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
