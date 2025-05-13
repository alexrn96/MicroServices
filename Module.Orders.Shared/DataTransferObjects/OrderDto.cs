

namespace Module.Orders.Shared.DataTransferObjects;
public class OrderDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ProductId { get; set; } // to connect with products microservices
    public int Quantity { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; }
}