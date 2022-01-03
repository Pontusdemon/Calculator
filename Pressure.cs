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
                Console.WriteLine("pressure = " + p);
            }
        }

        public class Fluid : Pressure
        {
            public double p;

            public double x;
            public double d;
            public double g;
            public double h;

            public override void Master()
            {
                p = x + (d * g * h);
                Console.WriteLine("fluid pressure = " + p);
            }
        }

        public class External : Pressure
        {
            public double x;

            public double p;
            public double d;
            public double g;
            public double h;

            public override void Master()
            {
                
            }
        }

        public class GeneralGaslaw : Pressure
        {
            public override void Master()
            {
                throw new NotImplementedException();
            }
        }
    }
}
