

using Module.Products.Shared.DataTransferObjects;

namespace Module.Products.Shared.Interfaces;
public interface IProductService
{
    public Task<List<ProductDto>> GetProducts();
    public Task<ProductDto> CreateProduct(ProductDto product);

    
}
