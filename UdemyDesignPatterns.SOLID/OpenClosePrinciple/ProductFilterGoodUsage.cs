using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.OpenClosePrinciple
{
    public class ProductFilterGoodUsage
    {
        public static void Run()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("1", Color.B, Size.Small));
            products.Add(new Product("2", Color.B, Size.Small));
            products.Add(new Product("3", Color.R, Size.Small));
            products.Add(new Product("4", Color.G, Size.Small));

            var bf = new BetterFilter();
            foreach (var p in bf.Filter(products, new ColorSpec(Color.B)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            var andSpec = new AndSpec<Product>(
                    new ColorSpec(Color.B),
                    new SizeSpec(Size.Small)
                );

            foreach (var p in bf.Filter(products, andSpec))
            {
                Console.WriteLine($"- {p.Name} is filtered by color and size");
            }
        }
    }
}
