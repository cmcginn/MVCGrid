using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grid.Client.Startup))]
namespace Grid.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
