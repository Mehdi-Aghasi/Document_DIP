using DIP_Factory;
using System;
using System.Collections.Generic;

namespace DIP_Factory
{
    class APIProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product { Name = "Scaneer", Price = 430000 },
            new Product { Name = "Mobile", Price = 90000 }
            };
        }
    }
}
