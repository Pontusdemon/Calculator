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

        public double ρ;
        public double V;

        public void MassByDensity()
        {
            Console.WriteLine("ρ = __");
            ρ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("V = __");
            V = Convert.ToDouble(Console.ReadLine());

            m = ρ * V;
            Console.WriteLine("m = " + m);
        }
    }
}
