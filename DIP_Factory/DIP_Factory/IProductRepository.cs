
using System;
using System.Collections.Generic;

namespace DIP_Factory
{
    interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
