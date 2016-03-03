using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(alphadrina.Startup))]
namespace alphadrina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
