

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Module.Products.Infrastructure.Persistence;
using Module.Products.Shared.DataTransferObjects;
using Module.Products.Shared.DBModels;
using Module.Products.Shared.Interfaces;

namespace Module.Products.Infrastructure.Services;
public class ProductService : IProductService
{
    private ProductDbContext _dbContext;
    private IMapper _mapper;

    public ProductService(ProductDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper=mapper;
    }
    public async Task<ProductDto> CreateProduct(ProductDto product)
    {
        EntityProduct entityProduct= _mapper.Map<EntityProduct>(product);  
        _dbContext.Products.Add(entityProduct); 
        await _dbContext.SaveChangesAsync();
        return product;
    }

    public async Task<List<ProductDto>> GetProducts()
    {
        List<EntityProduct> products= await _dbContext.Products.ToListAsync();
       return  _mapper.Map<List<ProductDto>>(products);
    }
}