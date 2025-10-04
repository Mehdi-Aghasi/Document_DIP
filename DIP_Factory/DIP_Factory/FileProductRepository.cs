using DIP_Factory;
using System;
using System.Collections.Generic;

namespace DIP_Factory
{
    class FileProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product { Name = "Mouse", Price = 1000 },
            new Product { Name = "Gamepad", Price = 7000 }
            };
        }
    }
}
