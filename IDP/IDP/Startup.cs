using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDP.Startup))]
namespace IDP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
