using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenRevolution.Startup))]
namespace GreenRevolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
