using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Image)
            .WithOne(i => i.Product)
            .HasForeignKey(i => i.ProductId);
    }
}