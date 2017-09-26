using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.LiskovSubstitution
{
    public class RectangleGood
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public RectangleGood()
        {

        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}";
        }
    }
}
