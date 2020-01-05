using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public interface ICart : IProductsCollection
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        void RemoveProduct(Guid id);
    }
}
