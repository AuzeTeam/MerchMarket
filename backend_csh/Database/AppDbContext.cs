using Microsoft.EntityFrameworkCore;

namespace backend_csh.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options, DbSet<Product> products) : base(options)
    {
        Products = products;
    }
    public DbSet<Product> Products { get; set; }
}