using System;
using System.Collections.Generic;
using MentorshipAppAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MentorshipAppAPI.Controllers
{
    [DisableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product(1, "Tuna", 2.75, "Tuna in olive oil."),
            new Product(2, "Apples", 1.75, "Fresh red apples."),
            new Product(3, "Oranges", 1.45, "Juicy oranges."),
            new Product(4, "Juice", 2.0, "Fresh apple juice.")
        };

        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return products.Find(item => item.Id == id);
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            products.Add(value);
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            int index = products.IndexOf(products.Find(item => item.Id == id));
            products[index] = value;
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = products.IndexOf(products.Find(item => item.Id == id));
            products.RemoveAt(index);
        }
    }
}
