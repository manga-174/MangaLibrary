using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MangaLibrary.Startup))]
namespace MangaLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
