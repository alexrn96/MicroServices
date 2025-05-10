

using AutoMapper;
using Module.Products.Shared.DataTransferObjects;
using Module.Products.Shared.DBModels;

namespace Module.Products.Infrastructure.Tools;
public class ProductMappingProfile:Profile
{
    public ProductMappingProfile()
    {
        ConfigureDtoToEntityMappings();
        ConfigureEntityToDtoMappings();
    }
    private void ConfigureDtoToEntityMappings()
    {
        CreateMap<ProductDto, EntityProduct>();
    }
    private void ConfigureEntityToDtoMappings()
    {
        CreateMap<EntityProduct,ProductDto>();  
    }
}