using Microsoft.EntityFrameworkCore;

namespace MovieApp_API.Models
{
    public class AppDbContext : DbContext
    {
        // Constructor with dependency injection
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Movies table
        public DbSet<Movie> Movies { get; set; }
    }
}