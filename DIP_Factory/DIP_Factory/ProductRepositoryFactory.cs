using System;
using System.Collections.Generic;

namespace DIP_Factory
{
    class ProductRepositoryFactory
    {

        public static IProductRepository CreateRepository(string sourceType)
        {
            switch (sourceType)
            {
                case "database":
                    return new DatabaseProductRepository();
                case "api":
                    return new APIProductRepository();
                case "File":
                    return new FileProductRepository();
                default:
                    throw new InvalidCastException("The data source is invalid");
            }
        }
    }
}
