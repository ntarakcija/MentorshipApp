using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public class CartIterator : IProductsIterator
    {
        private List<Product> _products;
        private int index;

        public CartIterator(List<Product> products)
        {
            _products = products;
            index = 0;
        }

        public bool HasNext()
        {
            if (index <= _products.Count - 1)
            {
                return true;
            }
            return false;
        }

        public Product Next()
        {
            return _products[index++];
        }
    }
}
