using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductRepository repository = new DatabaseProductRepository();
            //IProductRepository repository1 = new APIProductRepository();
            //IProductRepository repository1 = new FileProductRepository();

            ProductDisplay display = new ProductDisplay(repository);
            display.ShowProduct();
        }
    }
}
