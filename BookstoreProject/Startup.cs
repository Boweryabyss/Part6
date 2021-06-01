using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookstoreProject.Startup))]
namespace BookstoreProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
