using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwintonStatic.Startup))]
namespace SwintonStatic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
