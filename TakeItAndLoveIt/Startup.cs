using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakeItAndLoveIt.Startup))]
namespace TakeItAndLoveIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
