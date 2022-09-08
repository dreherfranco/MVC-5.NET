using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_5.NET.Startup))]
namespace MVC_5.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
