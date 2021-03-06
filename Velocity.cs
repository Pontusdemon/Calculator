using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Velocity
    {
        public abstract void VelocityMaster();

        public class Average : Velocity
        {
            public double v;
            public double s;
            public double t;

            public override void VelocityMaster()
            {
                v = s / t;
                Console.WriteLine("v = " + v);
            }
        }

        public class Master : Velocity
        {
            public double v;
            public double x;
            public double a;
            public double t;

            public override void VelocityMaster()
            {
                v = x + (a * t);
                Console.WriteLine("v = " + v);
            }

            public void InitialVelocity()
            {
                x = v - (a * t);
                Console.WriteLine("x = " + x);
            }
        }

        public class Timeless : Velocity
        {
            public double v;
            public double x;
            public double a;
            public double s;
            public double u;
            public double t;

            public override void VelocityMaster()
            {
                if (u > 0)
                {
                    s = (u * t) + ((a * Math.Pow(t, 2)) / 2);
                    x = u;
                }

                v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));

                Console.WriteLine("v = " + v);
            }

            public void InitialTimelssVelocity()
            {
                x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                Console.WriteLine("x = " + x);
            }
        }

        public class VelocityByDistance : Velocity
        {
            public double s;
            public double u;
            public double t;
            public double a;

            public override void VelocityMaster()
            {
                u = (s / t) - ((a * t) / 2);
                Console.WriteLine("u = " + u);
            }
        }
    }
}
