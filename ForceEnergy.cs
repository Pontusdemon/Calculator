using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ForceEnergy
    {
        public void ForceEnergySetup()
        {
            var InputSetup = new ProgramSetup();

            Console.WriteLine("select subject area");
            string ForceEnergySubject = Console.ReadLine();

            if (ForceEnergySubject == "force")
            {
                Console.WriteLine("enter force type");
                string ForceType = Console.ReadLine();

                if (ForceType == "general")
                {
                    var GeneralForce = new Force.Master();

                    Console.WriteLine("F = m * a");

                    Console.WriteLine(InputSetup.new_m);
                    GeneralForce.m = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_a);
                    GeneralForce.a = Convert.ToDouble(Console.ReadLine());

                    GeneralForce.MasterForce();
                }

                else if (ForceType == "friktion")
                {
                    var FriktionForce = new Force.Friktion();
                    Console.WriteLine("Ff = µ * Fn");

                    Console.WriteLine(InputSetup.new_µ);
                    FriktionForce.µ = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_Fn);
                    FriktionForce.Fn = Convert.ToDouble(Console.ReadLine());

                    FriktionForce.MasterForce();
                }

                else if (ForceType == "normal friktion")
                {
                    var NormalFriktion = new Force.Friktion();
                    Console.WriteLine("Fn = Ff / µ");

                    Console.WriteLine(InputSetup.new_Ff);
                    NormalFriktion.Ff = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_µ);
                    NormalFriktion.µ = Convert.ToDouble(Console.ReadLine());

                    NormalFriktion.NormalFriktionForce();
                }
            }

            else if (ForceEnergySubject == "energy")
            {
                Console.WriteLine("select energy type");
                string EnergyType = Console.ReadLine();

                if (EnergyType == "potential")
                {
                    var PotentialEnergy = new Energy.Potential();


                }
            }
        }
    }
}