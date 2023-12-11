using Microsoft.EntityFrameworkCore;

namespace Ef_Productmanagement{

    public class ProductContext:DbContext{
          public DbSet<Product> Productdetails { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=EfProduct;user=root;password=root");
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Product>(entity =>
      {
        entity.HasKey(e => e.ProductID);
        entity.Property(e => e.ProductName).IsRequired();
        entity.Property(e => e.ProductQuantity).IsRequired();
        entity.Property(e => e.ProductPrice).IsRequired();

      });

    }

    }
}