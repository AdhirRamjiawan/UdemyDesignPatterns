using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.LiskovSubstitution
{
    public class SquareBad : RectangleBad
    {
        public new int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }


        public new int Height
        {
            set
            {
                base.Width = base.Height = value;
            }
        }
    }
}
