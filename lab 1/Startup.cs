using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_1.Startup))]
namespace lab_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
