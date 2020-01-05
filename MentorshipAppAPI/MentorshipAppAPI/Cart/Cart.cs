using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public class Cart : ICart
    {
        private List<Product> _products;

        public Cart()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Guid id)
        {
            Product p = _products.Find(item => item.Id == id);
            _products.Remove(p);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public IProductsIterator GetProductsIterator()
        {
            return new CartIterator(_products);
        }
    }
}
