using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Volume
    {
        public abstract void MasterVolume();

        public class Density : Volume
        {
            public double V;
            public double d;
            public double m;

            public override void MasterVolume()
            {
                V = m / d;
                Console.WriteLine("V = " + V);
            }
        }

        public class Arkimedes : Volume
        {
            public double FL;
            public double ρ;
            public double V;
            public double g = 9.82;

            public override void MasterVolume()
            {
                V = FL / (ρ * g);
                Console.WriteLine("V = " + V);
            }
        }

        public class GeneralGaslaw : Volume
        {
            public double V;
            public double k;
            public double T;
            public double p;

            public override void MasterVolume()
            {
                V = (k * T) / p;
                Console.WriteLine("V = " + V);
            }
        }
    }
}