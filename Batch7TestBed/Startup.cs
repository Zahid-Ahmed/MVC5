using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Batch7TestBed.Startup))]
namespace Batch7TestBed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
