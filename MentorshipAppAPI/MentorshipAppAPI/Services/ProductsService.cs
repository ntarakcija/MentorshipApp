using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Services
{
    public class ProductsService : IProductService
    {
        private List<Product> products = new List<Product>()
        {
            new Product(1, "Tuna", 2.75, "Tuna in olive oil."),
            new Product(2, "Apples", 1.75, "Fresh red apples."),
            new Product(3, "Oranges", 1.45, "Juicy oranges."),
            new Product(4, "Juice", 2.0, "Fresh apple juice.")
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.Find(item => item.Id == id);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
