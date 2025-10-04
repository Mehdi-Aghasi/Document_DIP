using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the data source type[database/api/file]");
            string input=Console.ReadLine();

            try
            {
                IProductRepository repository = ProductRepositoryFactory.CreateRepository(input);
                ProductDisplay display = new ProductDisplay(repository);
                display.ShowProduct();
            }
            catch (InvalidDataSourceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
