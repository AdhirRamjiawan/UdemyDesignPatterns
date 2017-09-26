using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.LiskovSubstitution
{
    public class RectangleBad
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public RectangleBad()
        {

        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}";
        }
    }
}
