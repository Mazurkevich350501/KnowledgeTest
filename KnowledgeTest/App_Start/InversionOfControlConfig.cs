using Autofac;
using KnowledgeTest.Autofac;

namespace KnowledgeTest
{
    public class InversionOfControlConfig
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<WebModule>();
            return builder.Build();
        }
    }
}
