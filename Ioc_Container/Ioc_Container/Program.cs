using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc_Container
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();


            Console.WriteLine("Please enter the data source type [database/api/file]:");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "database":
                    serviceCollection.AddTransient<IProductRepository, DatabaseProductRepository>();
                    break;
                case "api":
                    serviceCollection.AddTransient<IProductRepository, APIProductRepository>();
                    break;
                case "file":
                    serviceCollection.AddTransient<IProductRepository, FileProductRepository>();
                    break;
                default:
                    Console.WriteLine("Invalid data source type.");
                    return;
            }

            serviceCollection.AddTransient<ProductDisplay>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var display = serviceProvider.GetRequiredService<ProductDisplay>();

            display.ShowProduct();
        }
    }
    }

