using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory
{
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }

    public class BadPoint
    {
        private double x, y;

        public BadPoint(double x, double y, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                case CoordinateSystem.Cartesian:
                    this.x = y;
                    this.y = y;
                    break;
                case CoordinateSystem.Polar:
                    this.x = x * Math.Cos(y);
                    this.y = y * Math.Sin(y);
                    break;
            }
            
        }


    }
}
