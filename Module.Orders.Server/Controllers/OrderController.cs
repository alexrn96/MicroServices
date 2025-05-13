using Microsoft.AspNetCore.Mvc;
using Module.Orders.Server.Generics;
using Module.Orders.Shared.DataTransferObjects;
using Module.Orders.Shared.Interfaces;

namespace Module.Orders.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController( IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetOrders()
        {
            //return await _orderService.GetOrders();
            return await GenericControllerErrorHandling.RunServiceMethod(_orderService.GetOrders);
        }
        [HttpPost]
        public async Task<ActionResult<OrderDto>> SaveOrder(OrderDto order)
        {
            //return await _orderService.CreateOrder(order);
            return await GenericControllerErrorHandling.RunServiceMethod(_orderService.CreateOrder, order);
        }
    }

}
