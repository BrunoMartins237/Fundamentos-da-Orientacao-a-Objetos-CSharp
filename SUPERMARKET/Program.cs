using System;
using System.Collections.Generic;
using SUPERMARKET1.Products.CleaningProduct;

namespace SUPERMARKET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var limpeza = new List<CleaningProduct>();
            var vanish = new CleaningProduct("Vanish: Limpa a Alma", 10);
            Console.WriteLine(vanish.NameOfProduct);
            Console.WriteLine(vanish.PriceOfProduct);
        }
    }
}
