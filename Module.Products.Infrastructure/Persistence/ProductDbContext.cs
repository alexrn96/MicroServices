
using Microsoft.EntityFrameworkCore;
using Module.Products.Shared.DBModels;

namespace Module.Products.Infrastructure.Persistence;
public class ProductDbContext:DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
    {
        
    }
    public DbSet<EntityProduct> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}