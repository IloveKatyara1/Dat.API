using DAT.API.Core.Interfaces;
using DAT.API.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DAT.API.Core
{
    public static class DI
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();

            return services;
        }
    }
}
