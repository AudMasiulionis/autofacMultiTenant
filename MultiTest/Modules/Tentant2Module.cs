using Autofac;
using Services;

namespace MultiTest.Modules
{
    public class Tentant2Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new Tenant2Service())
                .As<IService>()
                .InstancePerLifetimeScope();
        }
    }
}
