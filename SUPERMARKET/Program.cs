using System;
using SUPERMARKET1.Products.CleaningProduct;

namespace SUPERMARKET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cleaningproduct = new CleaningProduct("Vanish", 10);
            Console.WriteLine(cleaningproduct.NameOfProduct);
        }
    }
}
