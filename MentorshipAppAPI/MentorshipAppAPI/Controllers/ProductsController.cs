using System;
using System.Collections.Generic;
using MentorshipAppAPI.Models;
using MentorshipAppAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MentorshipAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productService)
        {
           _productsService = productService;
        }

        // GET api/products/cart
        [HttpGet("cart")]
        public ActionResult<IEnumerable<Product>> GetCart()
        {
            var res = _productsService.GetCartProducts();
            return Ok(res);
        }

        // GET api/cart
        [HttpGet("cart/price")]
        public ActionResult<IEnumerable<Product>> GetCartPrice()
        {
            var res = _productsService.GetCartPrice();
            return Ok(res);
        }

        // GET api/cart
        [HttpGet("cart/discount")]
        public ActionResult<IEnumerable<Product>> GetCartDiscountPrice()
        {
            var res = _productsService.GetCartDiscountPrice();
            return Ok(res);
        }

        // POST api/cart
        [HttpPost("cart/{id}")]
        public void AddToCart(Guid id)
        {
            _productsService.AddToCart(id);
        }

        // POST api/cart
        [HttpDelete("cart/{id}")]
        public void RemoveFromCart(Guid id)
        {
            _productsService.RemoveFromCart(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var res = _productsService.GetProducts();
            return Ok(res);
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(Guid id)
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
