using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Product.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }

        [HttpGet]
        public List<Product> Get()
        {
            List<Product> list = new List<Product>() {
                new Product(){Id=2,Rate=15,Name="Sanitizer" },
                new Product(){Id=3,Rate=5,Name="Glass" },
                new Product(){Id=4,Rate=10,Name="Face-Musk" },
            };

            return list;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}
