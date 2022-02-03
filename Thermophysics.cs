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
            var InputSetup = new ProgramSetup();

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

            else if (Subject == "force")
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

                else if (ForceType == "lift force")
                {
                    var Arkimedes = new Force.Arkimedes();
                    Console.WriteLine("FL = d * g * V");

                    Console.WriteLine(InputSetup.new_d);
                    Arkimedes.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_V);
                    Arkimedes.V = Convert.ToDouble(Console.ReadLine());

                    Arkimedes.MasterForce();
                }
            }

            else if (Subject == "volume")
            {
                Console.WriteLine("select how to calculate volume");
                string VolumeCalculation = Console.ReadLine();

                if (VolumeCalculation == "density")
                {
                    var VolumeByDensity = new Volume.Density();
                    Console.WriteLine("V = m / d");

                    Console.WriteLine(InputSetup.new_m);
                    VolumeByDensity.m = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_d);
                    VolumeByDensity.d = Convert.ToDouble(Console.ReadLine());

                    VolumeByDensity.MasterVolume();
                }

                else if (VolumeCalculation == "arkimedes")
                {
                    var ArkimedesVolume = new Volume.Arkimedes();
                    Console.WriteLine("V = FL / (d * g)");

                    Console.WriteLine(InputSetup.new_FL);
                    ArkimedesVolume.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_d);
                    ArkimedesVolume.d = Convert.ToDouble(Console.ReadLine());

                    ArkimedesVolume.MasterVolume();
                }

                else if (VolumeCalculation == "general gaslaw")
                {
                    var VolumeByGeneralGaslaw = new Volume.GeneralGaslaw();
                    Console.WriteLine("V = (k * T) / p");

                    Console.WriteLine(InputSetup.new_k);
                    VolumeByGeneralGaslaw.k = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_T);
                    VolumeByGeneralGaslaw.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_p);
                    VolumeByGeneralGaslaw.p = Convert.ToDouble(Console.ReadLine());

                    VolumeByGeneralGaslaw.MasterVolume();
                }
            }

            else if (Subject == "mass")
            {
                var GetMass = new Mass();
                Console.WriteLine("m = d * V");
                GetMass.MassByDensity();
            }

            else if (Subject == "deaph")
            {
                var GetDeaph = new Deaph();
                Console.WriteLine("h = p / (d * g)");
                GetDeaph.DeaphByFluidPressure();
            }

            else if (Subject == "area")
            {
                var GetArea = new Area.Pressure();
                Console.WriteLine("A = F / p");

                Console.WriteLine(InputSetup.new_F);
                GetArea.F = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(InputSetup.new_p);
                GetArea.p = Convert.ToDouble(Console.ReadLine());

                GetArea.PressureArea();
            }

            else if (Subject == "temperature")
            {
                var GetTemperature = new Temperature();
                Console.WriteLine("T = (p * V) / k");

                Console.WriteLine(InputSetup.new_p);
                GetTemperature.p = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(InputSetup.new_V);
                GetTemperature.V = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(InputSetup.new_k);
                GetTemperature.k = Convert.ToDouble(Console.ReadLine());

                GetTemperature.TemperatureByGeneralGaslaw();
            }
        }
    }
}
