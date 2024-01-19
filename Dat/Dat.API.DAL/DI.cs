using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Dat.API.DAL;

namespace BinanceCoupons.API.DAL
{
    public static class DI
    {
        public static IServiceCollection AddServices(string connetionString, IServiceCollection services)
        {
            return services.AddDbContext<AppDbContext>(option =>
                        option.UseSqlServer(connetionString));
        }
    }
}