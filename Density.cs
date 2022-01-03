using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Density
    {
        double d; // Density

        double m;
        double V;
        double p;
        double g = 9.82;
        double h;
        double FL;

        public void GeneralDensity()
            // d = m / V
        {
            Console.WriteLine("enter mass");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter volume");
            V = Convert.ToDouble(Console.ReadLine());

            d = m / V;
            Console.WriteLine("density = " + d);
        }

        public void FluidDensity()
        // d = p / (g * h)
        {
            Console.WriteLine("enter pressure");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter deaph");
            h = Convert.ToDouble(Console.ReadLine());

            d = p / (g * h);
            Console.WriteLine("fluid density = " + d);
        }

        public void ArkimedesDensity()
        // d = FL / (g * V)
        {
            Console.WriteLine("enter lift force");
            FL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter volume");
            V = Convert.ToDouble(Console.ReadLine());

            d = FL / (g * V);
            Console.WriteLine("density = " + d);
        }
    }
}
