using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moviesCollection.Startup))]
namespace moviesCollection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
