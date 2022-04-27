using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Vandal",
                Description = "Best gun in the world",
                Quantity = 3,
                Price = 2_900M,
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Phantom",
                Description = "Best spray gun",
                Quantity = 5,
                Price = 2_900M,
            });

            products.Add(new Product()
            {
                Id=3,
                Name = "Operator",
                Description="Hottest gun in the universe.",
                Quantity=10,
                Price = 4_700M,
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Sheriff",
                Description = "Hottest Pistol in the west",
                Quantity = 42,
                Price = 800M,
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Odin",
                Description = "RATATATATATA gun",
                Quantity = 69,
                Price = 3_200M,
            });

            products.Add(new Product()
            {
                Id = 6,
                Name = "Guardian",
                Description = "Most broken gun in the west",
                Quantity = 14,
                Price = 2_400M,
            });

            products.Add(new Product()
            {
                Id = 7,
                Name = "Ghost",
                Description = "John Wick's Gun",
                Quantity = 23,
                Price = 500M,
            });

        }

        public List<Product> GetAll()
        {
            return products;
        }

        public decimal GetGrandTotalAmount()
        {
            decimal grandTotalAmount = 0;
            foreach (var product in products)
            {
                grandTotalAmount += product.TotalAmount;
            }
            return grandTotalAmount;
        }
    }
}
