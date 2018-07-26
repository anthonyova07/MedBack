using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedBack.Startup))]
namespace MedBack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
