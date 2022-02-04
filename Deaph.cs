using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Deaph
    {
        // h = p / (d * g);

        public double g = 9.82;
        public double h;
        public double p;
        public double ρ;

        public void DeaphByFluidPressure()
        {
            Console.WriteLine("p = __");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("d = __");
            ρ = Convert.ToDouble(Console.ReadLine());

            h = p / (ρ * g);
            Console.WriteLine("h = " + h);
        }
    }
}