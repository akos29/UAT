using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UAT.Startup))]
namespace UAT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
