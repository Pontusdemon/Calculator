using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Distance
    {
        public double s; // distance

        public double v;
        public double t;
        public double x;
        public double a;
        public double u;

        public void DistanceByAverageVelocity()
        {
            s = v * t;
            Console.WriteLine("s = " + s);
        }

        public void TimelessDistance()
        {
            s = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * a);
            Console.WriteLine("s = " + s);
        }

        public void DistanceDistance()
        {
            s = (u * t) + ((a * Math.Pow(t, 2)) / 2);
            Console.WriteLine("s = " + s);
        }
    }
}
