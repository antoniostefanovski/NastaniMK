using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NastaniMK_2023.Startup))]
namespace NastaniMK_2023
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
