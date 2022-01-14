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

        // pressure
        // lift
        // force
        // forcemoment
        // Friktion
        // work
        // hookes law
    }
}
