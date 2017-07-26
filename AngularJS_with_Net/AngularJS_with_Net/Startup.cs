using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS_with_Net.Startup))]
namespace AngularJS_with_Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
