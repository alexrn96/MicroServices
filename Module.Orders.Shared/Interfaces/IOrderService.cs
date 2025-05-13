

using Module.Orders.Shared.DataTransferObjects;

namespace Module.Orders.Shared.Interfaces;
public interface IOrderService
{
    public Task<List<OrderDto>> GetOrders();  
    public Task<OrderDto> CreateOrder(OrderDto order);
}