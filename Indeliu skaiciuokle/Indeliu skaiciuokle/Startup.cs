using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Indeliu_skaiciuokle.Startup))]
namespace Indeliu_skaiciuokle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
