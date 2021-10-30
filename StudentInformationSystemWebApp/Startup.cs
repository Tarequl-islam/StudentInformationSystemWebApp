using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentInformationSystemWebApp.Startup))]
namespace StudentInformationSystemWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
