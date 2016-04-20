using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLab.Startup))]
namespace MvcLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
