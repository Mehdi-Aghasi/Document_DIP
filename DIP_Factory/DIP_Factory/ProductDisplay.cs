using DIP_Factory;
using System;
using System.Collections.Generic;

namespace DIP_Factory
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
            foreach (var item in Products)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Price);
            }
        }
    }
}
