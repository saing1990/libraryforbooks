using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(libraryforbooks.Startup))]
namespace libraryforbooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
