using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGoogleAPI.Startup))]
namespace TestGoogleAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
