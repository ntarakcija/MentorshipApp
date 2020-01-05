using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Models
{
    public class Product
    {
        public Product(Guid id, string name, double price, string description, ProductCategory category)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Category = category; 
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
    }
}
