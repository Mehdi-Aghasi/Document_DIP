using System;
using System.Collections.Generic;

namespace Product_DIP
{
    class ProductDisplay
    {
        private IProductRepository _repository;

        public ProductDisplay(IProductRepository repository)
        {
            _repository = repository;
        }

        public void ShowProduct()
        {
            var Products = _repository.GetProducts();
            foreach(var item in Products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
