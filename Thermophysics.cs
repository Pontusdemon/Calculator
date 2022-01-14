using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Thermophysics
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

                if (PressureType == "defined")
                {
                    Console.WriteLine("p = F / A");
                    var DefinedPressure = new Pressure.Defined();

                    Console.WriteLine("enter force");
                    DefinedPressure.F = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter area");
                    DefinedPressure.A = Convert.ToDouble(Console.ReadLine());

                    DefinedPressure.Master();
                }

                else if (PressureType == "fluid")
                {
                    Console.WriteLine("p = dgh");
                    var FluidPressure = new Pressure.Fluid();

                    Console.WriteLine("enter density");
                    FluidPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    FluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deaph");
                    FluidPressure.h = Convert.ToDouble(Console.ReadLine());

                    FluidPressure.Master();
                }

                else if (PressureType == "external")
                {

                }

                else if (PressureType == "gas")
                {
                    Console.WriteLine("p = (k * T) / V");
                }
            }

        }
    }

    public class ThermophysicsInputSetup
    {
        public string new_d = "d = __";
        public string new_m = "m = __";
        public string new_V = "V = __";
        public string new_p = "p = __";
        public string new_h = "h = __";
        public string new_FL = "FL = __";
        public string new_F = "F = __";
        public string new_A = "A = __";
        public string new_k = "k = __";
        public string new_T = "T = __";
        public string new_g = "g = __";
    }
}
