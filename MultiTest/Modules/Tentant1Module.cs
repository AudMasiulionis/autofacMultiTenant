using Autofac;
using Services;

namespace MultiTest.Modules
{
    public class Tentant1Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new Tenant1Service())
                .As<IService>()
                .InstancePerLifetimeScope();
        }
    }
}
