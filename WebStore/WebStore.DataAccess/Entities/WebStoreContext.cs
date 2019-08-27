using Microsoft.EntityFrameworkCore;

namespace WebStore.DataAccess.Entities
{
    public class WebStoreContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=WebStore;Trusted_Connection=True;");
            }
        }


        public DbSet<Product> Products { get; set; }
    }
}
