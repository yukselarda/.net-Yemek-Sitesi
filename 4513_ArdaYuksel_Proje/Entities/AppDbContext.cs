using Microsoft.EntityFrameworkCore;

namespace _4513_ArdaYuksel_Proje.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuration.CustomerConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
