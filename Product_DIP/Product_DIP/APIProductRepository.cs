using System;
using System.Collections.Generic;

namespace Product_DIP
{
    class APIProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product {Id=1, Name = "Scaneer", Price = 430000 },
            new Product {Id=2, Name = "Mobile", Price = 90000 }
            };
        }
    }
}
