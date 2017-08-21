using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTFdoIcookIt.Startup))]
namespace HTFdoIcookIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
