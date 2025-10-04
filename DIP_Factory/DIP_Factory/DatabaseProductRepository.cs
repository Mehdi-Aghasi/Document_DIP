using DIP_Factory;
using System;
using System.Collections.Generic;

namespace DIP_Factory
{
    class DatabaseProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product { Name = "Laptap", Price = 69000 },
            new Product { Name = "Consol", Price = 50000 }
             };
        }
    }
}
