using Microsoft.AspNetCore.Mvc;
using Product.Api.Models;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new ProductModel[3]
            {
                new ProductModel { Id = 1, Description = "Product 01", Price = 10.0M },
                new ProductModel { Id = 2, Description = "Product 02", Price = 15.0M },
                new ProductModel { Id = 3, Description = "Product 03", Price = 5.50M }
            };

            return Ok(products);
        }
    }
}
