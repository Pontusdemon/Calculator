using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Force
    {
        public abstract void MasterForce();

        public class Pressure : Force
        {
            public double F;
            public double p;
            public double A;
            public override void MasterForce()
            {
                F = p * A;
                Console.WriteLine("F = " + F);
            }
        }

        public class Arkimedes : Force
        {
            public double FL;
            public double d;
            public double g = 9.82;
            public double V;

            public override void MasterForce()
            {
                FL = d * g * V;
                Console.WriteLine("FL = " + FL);
            }
        }

        // pressure
        // lift
        // force
        // forcemoment
        // Friktion
        // work
        // hookes law
    }
}
