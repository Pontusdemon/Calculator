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
            var InputSetup = new ProgramSetup();

            Console.WriteLine(InputSetup.new_m);
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(InputSetup.new_V);
            V = Convert.ToDouble(Console.ReadLine());

            d = m / V;
            Console.WriteLine("d = " + d);
        }

        public void FluidDensity()
        // d = p / (g * h)
        {
            var InputSetup = new ProgramSetup();

            Console.WriteLine(InputSetup.new_p);
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(InputSetup.new_h);
            h = Convert.ToDouble(Console.ReadLine());

            d = p / (g * h);
            Console.WriteLine("d = " + d);
        }

        public void ArkimedesDensity()
        // d = FL / (g * V)
        {
            var InputSetup = new ProgramSetup();

            Console.WriteLine(InputSetup.new_FL);
            FL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(InputSetup.new_V);
            V = Convert.ToDouble(Console.ReadLine());

            d = FL / (g * V);
            Console.WriteLine("d = " + d);
        }
    }
}
