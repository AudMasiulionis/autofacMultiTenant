using Autofac.Multitenant;
using MultiTest.Modules;

namespace MultiTest
{
    public class MyTenantIdentificationStrategy : ITenantIdentificationStrategy
    {
        // inject some magic code to determine which tenant this is
        // for example add to header?!

        public bool TryIdentifyTenant(out object tenantId)
        {
            tenantId = Tenants.Tenant1;
            return tenantId != null;
        }
    }
}
