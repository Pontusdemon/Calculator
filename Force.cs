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

        public class Master : Force
        {
            public double F;
            public double m;
            public double a;
            public double g;

            public override void MasterForce()
            {
                if (g > 0)
                {
                    a = g;
                }

                F = m * a;
                Console.WriteLine("F = " + F);
            }
        }

        public class Friktion : Force
        {
            public double Ff;
            public double Fn;
            public double friktion_k;

            public override void MasterForce()
            {
                Ff = friktion_k * Fn;
                Console.WriteLine("Ff = " + Ff);
            }
        }

        public class Hookes : Force
        {
            public double F;
            public double k;
            public double dl;

            public override void MasterForce()
            {
                F = k * dl;
                Console.WriteLine("F = " + F);
            }
        }

        public class Work : Force
        {
            public double Fs;
            public double W;
            public double s;

            public override void MasterForce()
            {
                Fs = W / s;
                Console.WriteLine("Fs = " + Fs);
            }
        }

        public class Momental : Force
        {
            public double M;
            public double F;
            public double l;

            public override void MasterForce()
            {
                M = F * l;
                Console.WriteLine("M = " + M);
            }
        }
    }
}