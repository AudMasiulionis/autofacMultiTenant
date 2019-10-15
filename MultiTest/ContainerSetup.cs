using Autofac;
using Autofac.Multitenant;
using MultiTest.Modules;

namespace MultiTest
{
    public static class ContainerSetup
    {
        public static void SetupCommonContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonModule>();
        }

        public static MultitenantContainer ConfigureMultitenantContainer(IContainer container)
        {
            var strategy = new MyTenantIdentificationStrategy();
            var multitenantContainer = new MultitenantContainer(strategy, container);

            multitenantContainer.ConfigureTenant(Tenants.Tenant1, cb => cb.RegisterModule<Tentant1Module>());
            multitenantContainer.ConfigureTenant(Tenants.Tenant2, cb => cb.RegisterModule<Tentant2Module>());

            return multitenantContainer;
        }
    }
}
