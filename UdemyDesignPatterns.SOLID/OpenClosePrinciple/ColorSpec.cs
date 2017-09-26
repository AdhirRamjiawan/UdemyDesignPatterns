using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.OpenClosePrinciple
{
    public class ColorSpec : ISpecification<Product>
    {
        private Color Color;

        public ColorSpec(Color color)
        {
            Color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == Color;
        }
    }
}
