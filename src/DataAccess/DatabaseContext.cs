// DatabaseContext.cs

using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Interaction> Interactions { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Veritabanı bağlantı dizesini burada ayarlayın
        optionsBuilder.UseSqlServer("your_connection_string");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Model oluşturma ve ilişkilendirme ayarlarını burada yapabilirsiniz
        modelBuilder.Entity<OrderItem>()
            .HasKey(oi => new { oi.OrderId, oi.ProductId });

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Product)
            .WithMany()
            .HasForeignKey(oi => oi.ProductId);
    }
}
