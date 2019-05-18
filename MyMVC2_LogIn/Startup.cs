using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVC2_LogIn.Startup))]
namespace MyMVC2_LogIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
