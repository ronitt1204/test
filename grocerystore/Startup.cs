using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(grocerystore.Startup))]
namespace grocerystore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
