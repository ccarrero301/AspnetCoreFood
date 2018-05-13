using AspNetCoreFood.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreFood.Data
{
    public class AspNetCoreFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public AspNetCoreFoodDbContext(DbContextOptions options)
            : base(options)
        {
            
        }
    }
}
