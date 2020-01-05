using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI.Models
{
    public class Deal
    {
        public Deal(Guid id, string name, double price, string description, DealCategory category, IEnumerable<Product> items)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Items = items;
        }

        public Deal() { }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DealCategory Category { get; set; }
        public IEnumerable<Product> Items { get; set; }
    }
}
