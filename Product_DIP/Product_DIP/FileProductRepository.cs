using System;
using System.Collections.Generic;

namespace Product_DIP
{
    class FileProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product {Id=001, Name = "Mouse", Price = 1000 },
            new Product {Id=002, Name = "Gamepad", Price = 7000 }
            };
        }
    }
}
