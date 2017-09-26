using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.LiskovSubstitution
{
    public class SquareGood : RectangleGood
    {
        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }


        public override int Height
        {
            set
            {
                base.Width = base.Height = value;
            }
        }
    }
}
