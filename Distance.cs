using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Distance
    {
        // s = v * t
        // s = (v^2 + x^2) / 2a
        // s = ut + (at^2) / 2

        public double s;
        public double v;
        public double t;
        public double x;
        public double a;
        public double u;

        public void DistanceByAverageVelocity()
        {
            s = v * t;
            Console.WriteLine("distance = " + s);
        }

        public void TimelessDistance()
        {
            s = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * a);
            Console.WriteLine("distance = " + s);
        }

        public void DistanceDistance()
        {
            s = (u * t) + ((a * Math.Pow(t, 2)) / 2);
            Console.WriteLine("distance = " + s);
        }
    }
}
