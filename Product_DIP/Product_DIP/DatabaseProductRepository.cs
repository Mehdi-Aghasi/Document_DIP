using System;
using System.Collections.Generic;

namespace Product_DIP
{
    class DatabaseProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>() 
            {
            new Product {Id=101, Name = "Laptap", Price = 69000 },
            new Product {Id=102, Name = "Consol", Price = 50000 }
            };
        }
    }
}
