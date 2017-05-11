using Autofac;
using KnowledgeTest.BLL.Interface;
using KnowledgeTest.BLL.Service;
using KnowledgeTest.DAL.Autofac;

namespace KnowledgeTest.BLL.Autofac
{
    public class BllModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DalModule>();
            builder.RegisterType<TestService>().As<ITestService>();
        }
    }
}