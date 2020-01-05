using MentorshipAppAPI.Models;
using MentorshipAppAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipAppAPI
{
    public class DealsFactory : IDealsFactory
    {
        private readonly IProductsService _productsService;

        public DealsFactory(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public Deal GetDeal(DealCategory category)
        {
            switch (category)
            {
                case DealCategory.Christmas:
                    return CreateChristmasDeal();
                case DealCategory.NewYear:
                    return CreateNewYearDeal();
                case DealCategory.Love:
                    return CreateLoveDeal();
                default:
                    return new Deal();
            }
        }

        private Deal CreateChristmasDeal()
        {
            List<Product> products = _productsService.GetProducts() as List<Product>;
            List<Product> items = new List<Product>();
            List<Product> christmasProducts = products.FindAll(item => 
                item.Category == ProductCategory.Gift || item.Category == ProductCategory.Clothes);

            // Get three random items from christmasProducts
            for (int i = 0; i < 3; i++)
            {
                if (i >= christmasProducts.Count)
                {
                    break;
                }
                Random randomNumber = new Random();
                items.Add(christmasProducts[randomNumber.Next(0, christmasProducts.Count - 1)]);
            }

            Deal deal = new Deal()
            {
                Id = Guid.NewGuid(),
                Category = DealCategory.Christmas,
                Name = "Xmas deal for you",
                Description = "Surprise your family and friends with this special deal for you.",
                Items = items,
                Price = items.Sum(item => item.Price) * 0.9
            };

            return deal;
        }

        private Deal CreateNewYearDeal()
        {
            List<Product> products = _productsService.GetProducts() as List<Product>;
            List<Product> items = new List<Product>();
            List<Product> newYearProducts = products.FindAll(item =>
                item.Category == ProductCategory.Gift || item.Category == ProductCategory.Tech
                || item.Category == ProductCategory.Love);

            // Get three random items from christmasProducts
            for (int i = 0; i < 3; i++)
            {
                if (i >= newYearProducts.Count)
                {
                    break;
                }
                Random randomNumber = new Random();
                items.Add(newYearProducts[randomNumber.Next(0, newYearProducts.Count - 1)]);
            }

            Deal deal = new Deal()
            {
                Id = Guid.NewGuid(),
                Category = DealCategory.NewYear,
                Name = "New Year deal for you",
                Description = "Surprise your family and friends with this special deal for you.",
                Items = items,
                Price = items.Sum(item => item.Price) * 0.9
            };

            return deal;
        }

        private Deal CreateLoveDeal()
        {
            List<Product> products = _productsService.GetProducts() as List<Product>;
            List<Product> items = new List<Product>();
            List<Product> loveProducts = products.FindAll(item =>
                item.Category == ProductCategory.Love || item.Category == ProductCategory.Pets);

            // Get three random items from christmasProducts
            for (int i = 0; i < 3; i++)
            {
                if (i >= loveProducts.Count)
                {
                    break;
                }
                Random randomNumber = new Random();
                items.Add(loveProducts[randomNumber.Next(0, loveProducts.Count - 1)]);
            }

            Deal deal = new Deal()
            {
                Id = Guid.NewGuid(),
                Category = DealCategory.Love,
                Name = "Romantic deal for you",
                Description = "Surprise your special one with this special deal for you.",
                Items = items,
                Price = items.Sum(item => item.Price) * 0.9
            };

            return deal;
        }
    }
}
