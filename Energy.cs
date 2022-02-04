using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Energy
    {
        public abstract void MasterEnergy();

        public class Potential : Energy
        {
            public double Ep;
            public double m;
            public double g = 9.82;
            public double h;

            public override void MasterEnergy()
            {
                Ep = m * g * h;
                Console.WriteLine("Ep = " + Ep);
            }

            public class Gravitationfield : Potential
            {
                public double G;
                public double m1;
                public double m2;
                public double r;

                public override void MasterEnergy()
                {
                    Ep = -G * (m1 * m2) / r;
                    Console.WriteLine("Ep = " + Ep);
                }
            }

            public class Spring : Potential
            {
                public double k;
                public double l1;
                public double l2;
                public double dl;

                public override void MasterEnergy()
                {
                    dl = l2 - l1;
                    Ep = (k * Math.Pow(dl, 2)) / 2;
                    Console.WriteLine("Ep = " + Ep);
                }
            }
        }

        public class Kinetic : Energy
        {
            public double Ek;
            public double m;
            public double v;

            public override void MasterEnergy()
            {
                Ek = (m * Math.Pow(v, 2)) / 2;
                Console.WriteLine("Ek = " + Ek);
            }
        }

        public class Total : Energy
        {
            public double E;
            public double k;
            public double A;

            public override void MasterEnergy()
            {
                E = (k * Math.Pow(A, 2)) / 2;
                Console.WriteLine("E = " + E);
            }
        }
    }
}
