

using AutoMapper;
using Module.Orders.Shared.DataTransferObjects;
using Module.Orders.Shared.DBModels;

namespace Module.Orders.Infrastructure.Tools;
public class OrderMappingProfile:Profile
{
    public OrderMappingProfile()
    {
        ConfigureDtoToEntityMappings();
        ConfigureEntityToDtoMappings();
    }
    private void ConfigureDtoToEntityMappings()
    {
        CreateMap<OrderDto, EntityOrder>();
    }
    private void ConfigureEntityToDtoMappings()
    {
        CreateMap<EntityOrder, OrderDto>();
    }
}
