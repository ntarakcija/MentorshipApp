using MentorshipAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetCartProducts();
        Product GetProduct(Guid id);
        void AddProduct(Product product);
        void AddToCart(Guid id);
        void RemoveFromCart(Guid id);
        double GetCartPrice();
        double GetCartDiscountPrice();

    }
}
