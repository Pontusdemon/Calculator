using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Mass
    {
        public double m;

        public double d;
        public double V;

        public void MassByDensity()
        {
            m = d * V;
            Console.WriteLine("m = " + m);
        }
    }
}
