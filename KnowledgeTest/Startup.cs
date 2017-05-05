using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnowledgeTest.Startup))]
namespace KnowledgeTest
{
    public partial class Startup
    {
        public static IContainer Container;
        public void Configuration(IAppBuilder app)
        {
            Container = InversionOfControlConfig.CreateContainer();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
            ConfigureAuth(app);
        }
    }
}
