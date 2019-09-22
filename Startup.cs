using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jm555115_MIS4200_1.Startup))]
namespace jm555115_MIS4200_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
