using Autofac;
using KnowledgeTest.DAL.Autofac;

namespace KnowledgeTest.BLL.Autofac
{
    public class BllModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DalModule>();
        }
    }
}