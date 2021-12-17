using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Acceleration
    {
        public double a;
        public double v;
        public double x;
        public double t;
        public double u;
        public double s;
        public double g;

        public void GeneralAcceleration()
        {
            a = (v - x) / t;
            Console.WriteLine("acceleration = " + a);
        }

        public void TimelessAcceleration()
        {
            a = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * s);
            Console.WriteLine("acceleration = " + a);
        }

        public void AccelerationByDistance()
        {
            a = (2 * (s - (u * t))) / Math.Pow(t, 2);
            Console.WriteLine("acceleration = " + a);
        }
    }
}
