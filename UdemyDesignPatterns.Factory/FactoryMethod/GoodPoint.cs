using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory
{
    public class GoodPoint
    {
        private double x, y;

        // important to keep private. Limits object creation outside of this class.
        private GoodPoint(double x, double y)
        {
            this.x = y;
            this.y = y;
        }

        // factory method
        public static GoodPoint NewCartesianPoint(double x, double y)
        {
            return new GoodPoint(x, y);
        }

        // factory method
        public static GoodPoint NewPolarPoint(double rho, double thetha)
        {
            return new GoodPoint(rho * Math.Cos(thetha), rho * Math.Sin(thetha));
        }
    }
}
