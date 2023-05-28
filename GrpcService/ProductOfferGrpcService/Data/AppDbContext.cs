using Microsoft.EntityFrameworkCore;
using ProductOfferGrpcService.Entities;

namespace ProductOfferGrpcService.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Offer> Offer { get; set; }
    }
}
