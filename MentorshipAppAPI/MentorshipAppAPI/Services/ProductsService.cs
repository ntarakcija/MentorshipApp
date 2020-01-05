using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Services
{
    public class ProductsService : IProductsService
    {
        private List<Product> _products = new List<Product>()
        {
            new Product(Guid.NewGuid(), "Tuna", 2.75, "Tuna in olive oil.", ProductCategory.Food),
            new Product(Guid.NewGuid(), "Apples", 1.75, "Fresh red apples.", ProductCategory.Food),
            new Product(Guid.NewGuid(), "Oranges", 1.45, "Juicy oranges.", ProductCategory.Food),
            new Product(Guid.NewGuid(), "T-shirt", 10.0, "Colorful Christmas T-shirt.", ProductCategory.Clothes),
            new Product(Guid.NewGuid(), "Sweather", 15.0, "Santa sweather, brings happiness.", ProductCategory.Clothes),
            new Product(Guid.NewGuid(), "Lamp", 25.40, "It will lighten your day (and night).", ProductCategory.Gift),
            new Product(Guid.NewGuid(), "Heart", 3.50, "Show someone you love them.", ProductCategory.Love),
            new Product(Guid.NewGuid(), "Pen", 2.30, "Magic pen.", ProductCategory.Office),
            new Product(Guid.NewGuid(), "Dog", 145.60, "Get rich with this golden retriever.", ProductCategory.Pets),
            new Product(Guid.NewGuid(), "Keyboard", 35.0, "High-end keyboard, perfect for everyone's fingers.", ProductCategory.Tech),
            new Product(Guid.NewGuid(), "Laptop", 2199.99, "Dell, i5, SSD.", ProductCategory.Tech)
        };

        private ICart _cart;

        public ProductsService(ICart cart)
        {
            _cart = cart;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProduct(Guid id)
        {
            return _products.Find(item => item.Id == id);
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddToCart(Guid id)
        {
            _cart.AddProduct(_products.Find(item => item.Id == id));
        }

        public void RemoveFromCart(Guid id)
        {
            _cart.RemoveProduct(id);
        }

        public IEnumerable<Product> GetCartProducts()
        {
            return _cart.GetAllProducts();
        }

        public double GetCartPrice()
        {
            double price = 0;
            IProductsIterator cartIterator = _cart.GetProductsIterator();

            while (cartIterator.HasNext())
            {
                price += cartIterator.Next().Price;
            }

            return price;
        }

        public double GetCartDiscountPrice()
        {
            return GetCartPrice() * 0.8;
        }
    }
}
