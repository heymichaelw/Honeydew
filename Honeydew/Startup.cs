using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Honeydew.Startup))]
namespace Honeydew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
