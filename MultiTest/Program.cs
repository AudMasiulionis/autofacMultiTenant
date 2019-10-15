using System.IO;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace MultiTest
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseAutofacMultitenantRequestServices()
                .ConfigureServices(sp =>
                {
                    sp.AddSingleton<IServiceProviderFactory<ContainerBuilder>>(
                        new AutofacMultitenantServiceProviderFactory(ContainerSetup.ConfigureMultitenantContainer));
                }).Build().RunAsync();
        }
    }
}
