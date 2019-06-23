using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicConnectionString.Startup))]
namespace DynamicConnectionString
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
