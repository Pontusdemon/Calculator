using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Energy
    {
        public class Potential : Energy
        {
            public double Ep;
            public double m;
            public double g = 9.82;
            public double h;

            public class Gravitationfield : Potential
            {
                public double G;
                public double m1;
                public double m2;
                public double r;


            }

            // fjäder
        }

        public class Kinetic : Energy
        {
            public double Ek;
            public double m;
            public double v;


        }

        public class Total : Energy
        {
            public double E;
            public double k;
            public double A;
        }
    }
}
