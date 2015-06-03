using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LESSTest.Startup))]
namespace LESSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
