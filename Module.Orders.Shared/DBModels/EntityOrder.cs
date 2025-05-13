

namespace Module.Orders.Shared.DBModels;
public class EntityOrder
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ProductId { get; set; } // to connect with products microservices
    public int Quantity { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; } 
}