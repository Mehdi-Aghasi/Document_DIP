using System;
using System.Collections.Generic;

namespace Product_DIP
{
    interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
