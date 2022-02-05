using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Pressure
    {
        public abstract void Master();

        public class Defined : Pressure
        {
            public double p;
            public double F;
            public double A;

            public override void Master()
            {
                p = F / A;
                Console.WriteLine("p = " + p);
            }
        }

        public class Fluid : Pressure
        {
            public double p;
            public double x;
            public double ρ;
            public double g = 9.82;
            public double h;

            public override void Master()
            {
                p = x + (ρ * g * h);
                Console.WriteLine("p = " + p);
            }
        }

        public class External : Pressure
        {
            public double x;

            public double p;
            public double ρ;
            public double g = 9.82;
            public double h;

            public override void Master()
            {
                x = p - (ρ * g * h);
                Console.WriteLine("p = " + p);
            }
        }

        public class GeneralGaslaw : Pressure
        {
            public double p;
            public double k;
            public double T;
            public double V;

            public override void Master()
            {
                p = (k * T) / V;
                Console.WriteLine("p = " + p);
            }
        }
    }
}
