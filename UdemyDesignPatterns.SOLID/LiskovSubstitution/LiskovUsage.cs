using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.LiskovSubstitution
{
    public class LiskovUsage 
    {
        /* Need a better example of this. However the basis of this principle is 
         * to ensure that a derived type can still function correctly when stored in a
         * reference 
         */

        public int Area(RectangleBad r) => r.Width * r.Height;

        public static void Run()
        {
            SquareBad s = new SquareBad() { Height = 4, Width =3 }; // this is okay
            RectangleBad rS = new SquareBad() { Height = 4, Width = 3 }; // this produces incorrect results

            RectangleGood rS2 = new SquareGood() { Height = 4, Width = 3 }; // this is perfect
        }
    }
}
