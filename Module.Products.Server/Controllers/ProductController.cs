using Microsoft.AspNetCore.Mvc;
using Module.Products.Server.Generics;
using Module.Products.Shared.DataTransferObjects;
using Module.Products.Shared.Interfaces;

namespace Module.Products.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            //return await _productService.GetProducts(); 
            return await GenericControllerErrorHandling.RunServiceMethod(_productService.GetProducts);
        }
        [HttpPost]
        public async Task<ActionResult<ProductDto>> SaveProduct(ProductDto product)
        {
           // return await _productService.CreateProduct(product);
           return await GenericControllerErrorHandling.RunServiceMethod(_productService.CreateProduct, product);
        }
    }
}
