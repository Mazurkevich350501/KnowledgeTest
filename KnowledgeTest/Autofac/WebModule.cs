using Autofac;
using Autofac.Integration.Mvc;
using KnowledgeTest.BLL.Autofac;

namespace KnowledgeTest.Autofac
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<BllModule>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
        }
    }
}