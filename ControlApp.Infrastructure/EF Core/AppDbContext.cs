using ControlApp.Core.Extensions;
using ControlApp.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlApp.EF;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options)
    {
        this.Database.EnsureCreated();
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(x => x.Login)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasData(new User
        {
            Id = 1,
            Name = "Админ",
            Login = "admin",
            PasswordHash = "admin".GeneratePasswordHash()
        });

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Manufacturer);

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Name);

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Category);
    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductIncome> ProductIncomes => Set<ProductIncome>();
    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<ProductReturn> ProductReturns => Set<ProductReturn>();
}
