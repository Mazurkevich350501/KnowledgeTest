using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnowledgeTest.Startup))]
namespace KnowledgeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
