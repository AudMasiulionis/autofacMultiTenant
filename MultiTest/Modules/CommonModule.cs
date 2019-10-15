using Autofac;

namespace MultiTest.Modules
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.Register(c => new ServiceGateWay())
            //    .As<IServiceGateWay>()
            //    .InstancePerLifetimeScope();
        }
    }
}
