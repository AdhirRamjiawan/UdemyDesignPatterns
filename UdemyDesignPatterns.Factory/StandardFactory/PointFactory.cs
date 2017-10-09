using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory.StandardFactory
{
    public class PointFactory
    {
        public static GoodPoint NewCartesianPoint(double x, double y)
        {
            return new GoodPoint(x, y); // using public constructor (NOT GOOD)
        }

        // factory method
        public static GoodPoint NewPolarPoint(double rho, double thetha)
        {
            return new GoodPoint(rho * Math.Cos(thetha), rho * Math.Sin(thetha));
        }
    }
}
