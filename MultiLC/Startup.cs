using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiLC.Startup))]
namespace MultiLC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
