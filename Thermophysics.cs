using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Thermophysics
    {
        public void ThermophysicsSelector()
        {
            Console.WriteLine("select thermophysics area");
            string Subject = Console.ReadLine();

            if (Subject == "density")
            {
                var Density = new Density();

                Console.WriteLine("select density type");
                string DensityType = Console.ReadLine();

                if (DensityType == "general")
                {
                    Console.WriteLine("d = m / V");
                    Density.GeneralDensity();
                }

                else if (DensityType == "fluid")
                {
                    Console.WriteLine("d = p / (g * h)");
                    Density.FluidDensity();
                }

                else if (DensityType == "arkimedes")
                {
                    Console.WriteLine("d = FL / (g * v)");
                    Density.ArkimedesDensity();
                }
            }

            else if (Subject == "pressure")
            {
                Console.WriteLine("enter pressure type");
                string PressureType = Console.ReadLine();

                if (PressureType == "")
                {

                }
            }

        }
    }
}
