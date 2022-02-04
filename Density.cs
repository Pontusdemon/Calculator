using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Density
    {
        double ρ; // Density

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

            ρ = m / V;
            Console.WriteLine("ρ = " + ρ);
        }

        public void FluidDensity()
        // d = p / (g * h)
        {
            var InputSetup = new ProgramSetup();

            Console.WriteLine(InputSetup.new_p);
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(InputSetup.new_h);
            h = Convert.ToDouble(Console.ReadLine());

            ρ = p / (g * h);
            Console.WriteLine("ρ = " + ρ);
        }

        public void ArkimedesDensity()
        // d = FL / (g * V)
        {
            var InputSetup = new ProgramSetup();

            Console.WriteLine(InputSetup.new_FL);
            FL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(InputSetup.new_V);
            V = Convert.ToDouble(Console.ReadLine());

            ρ = FL / (g * V);
            Console.WriteLine("ρ = " + ρ);
        }
    }
}
