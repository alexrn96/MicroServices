
namespace Module.Products.Shared.DBModels;
public class EntityProduct
{
    public Guid Id { get; set; } = new Guid();
    public string Name { get; set; }
    public decimal Price { get; set; }  
}