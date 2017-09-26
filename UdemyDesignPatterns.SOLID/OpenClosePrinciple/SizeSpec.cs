using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.OpenClosePrinciple
{
    public class SizeSpec : ISpecification<Product>
    {
        public Size Size { get; set; }

        public SizeSpec(Size size)
        {
            Size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return Size == t.Size;
        }
    }
}
