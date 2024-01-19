using Dat.API.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Dat.API.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
