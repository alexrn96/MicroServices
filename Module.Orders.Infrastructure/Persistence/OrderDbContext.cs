
using Microsoft.EntityFrameworkCore;
using Module.Orders.Shared.DBModels;

namespace Module.Orders.Infrastructure.Persistence;
public class OrderDbContext:DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options): base(options)
    {
        
    }
    public DbSet<EntityOrder> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}