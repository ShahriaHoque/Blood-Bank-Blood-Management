using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hridoy25._08._22.Startup))]
namespace Hridoy25._08._22
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
