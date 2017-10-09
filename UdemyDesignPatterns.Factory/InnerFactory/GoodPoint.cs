using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory.InnerFactory
{
    public class GoodPoint
    {
        private double x, y;

        private GoodPoint(double x, double y)
        {
            this.x = y;
            this.y = y;
        }

        // Inner factory pattern that prevents class having public contructor.
        public static class Factory
        {
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
}
