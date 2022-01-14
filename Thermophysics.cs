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
            var InputSetup = new ThermophysicsInputSetup();

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
                    Console.WriteLine("d = FL / (g * V)");
                    Density.ArkimedesDensity();
                }
            }

            else if (Subject == "pressure")
            {
                Console.WriteLine("select pressure type");
                string PressureType = Console.ReadLine();

                if (PressureType == "defined")
                {
                    Console.WriteLine("p = F / A");
                    var DefinedPressure = new Pressure.Defined();

                    Console.WriteLine(InputSetup.new_F);
                    DefinedPressure.F = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_A);
                    DefinedPressure.A = Convert.ToDouble(Console.ReadLine());

                    DefinedPressure.Master();
                }

                else if (PressureType == "fluid")
                {
                    Console.WriteLine("p = dgh");
                    var FluidPressure = new Pressure.Fluid();

                    Console.WriteLine(InputSetup.new_d);
                    FluidPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_h);
                    FluidPressure.h = Convert.ToDouble(Console.ReadLine());

                    FluidPressure.Master();
                }

                else if (PressureType == "external")
                {
                    Console.WriteLine("x = p - dgh");
                    var ExternalPressure = new Pressure.External();

                    Console.WriteLine(InputSetup.new_p);
                    ExternalPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_d);
                    ExternalPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_h);
                    ExternalPressure.h = Convert.ToDouble(Console.ReadLine());

                    ExternalPressure.Master();
                }

                else if (PressureType == "gas")
                {
                    Console.WriteLine("p = (k * T) / V");
                    var GasPressure = new Pressure.GeneralGaslaw();

                    Console.WriteLine(InputSetup.new_k);
                    GasPressure.k = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_T);
                    GasPressure.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_V);
                    GasPressure.V = Convert.ToDouble(Console.ReadLine());

                    GasPressure.Master();
                }
            }

            else if (Subject == "force") ;
            {
                Console.WriteLine("select force type");
                string ForceType = Console.ReadLine();

                if (ForceType == "pressure")
                {
                    Console.WriteLine("F = p * A");
                    var PressureForce = new Force.Pressure();

                    Console.WriteLine(InputSetup.new_p);
                    PressureForce.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_A);
                    PressureForce.A = Convert.ToDouble(Console.ReadLine());

                    PressureForce.MasterForce();
                }
            }
        }

        // mass
        // volume
        // force
        // Temperature
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
