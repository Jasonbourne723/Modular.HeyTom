using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Runtime.Loader;

namespace HeyTom.Web.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddInject(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.Scan(scan => scan.FromAssemblies(assemblies)
               .AddClasses(x => x.Where(y => y.Name.EndsWith("Repository", StringComparison.OrdinalIgnoreCase) || y.Name.EndsWith("Service", StringComparison.OrdinalIgnoreCase)))
               .AsImplementedInterfaces()
               .WithTransientLifetime());
            return services;
        }
    }
}