using System;
using System.Collections.Generic;
using MentorshipAppAPI.Models;
using MentorshipAppAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MentorshipAppAPI.Controllers
{
    [DisableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productsService = new ProductsService();

        public ProductsController()
        {
           
        }

        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var res = _productsService.GetProducts();
            return Ok(res);
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var res = _productsService.GetProduct(id);
            return Ok(res);
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _productsService.AddProduct(value);
        }
    }
}
