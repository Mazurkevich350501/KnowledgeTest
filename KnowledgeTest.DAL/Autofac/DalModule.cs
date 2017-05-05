using Autofac;
using System.Data.Entity;

namespace KnowledgeTest.DAL.Autofac
{
    public class DalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestKnowledgeContext>().As<DbContext>();

        }
    }
}