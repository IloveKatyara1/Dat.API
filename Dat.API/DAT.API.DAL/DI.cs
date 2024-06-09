using DAT.API.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT.API.DAL
{
    public static class DI
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, string connetionString)
        {
            return services.AddDbContext<AppDbContext>(option =>
                option.UseSqlServer(connetionString, ss =>
                {
                    ss.EnableRetryOnFailure(3);
                }).EnableSensitiveDataLogging());
        }
    }
}
