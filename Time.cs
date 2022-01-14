using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Time
    {
        public double t; // time

        public double s;
        public double v;
        public double x;
        public double a;
        public double u;

        public void TimeByAverageVelocity()
        {
            t = s / v;
            Console.WriteLine("t = " + t);
        }

        public void TimeByAcceleration()
        {
            t = (v - x) / a;
            Console.WriteLine("t = " + t);
        }

        public void TimeByDistance()
        {
            t = (-u + Math.Sqrt(Math.Pow(u, 2) + (2 * a * s))) / a;
            Console.WriteLine("t = " + t);
        }
    }
}
