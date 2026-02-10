using Microsoft.EntityFrameworkCore;

namespace Assignment_2.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Data Source=MSI\\HSQL;Initial Catalog=ProductCatalog;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
            );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
