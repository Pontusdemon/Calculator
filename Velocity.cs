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
                Console.WriteLine("average velocity = " + v);
            }
        }

        public class Timeless : Velocity
        {
            public double v;
            public double x;
            public double a;
            public double s;
            public double u;

            public override void VelocityMaster()
            {
                v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));

                if (u > 0)
                {
                    x = u;
                }

                Console.WriteLine("velocity = " + v);
            }

            public void InitialTimelssVelocity()
            {
                x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                Console.WriteLine("initial velocity = " + x);
            }
        }
    }
}
