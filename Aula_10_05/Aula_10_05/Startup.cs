using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula_10_05.Startup))]
namespace Aula_10_05
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
