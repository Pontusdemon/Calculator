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
            Console.WriteLine("select subject area");
            string ForceEnergySubject = Console.ReadLine();

            if (ForceEnergySubject == "force")
            {
                Console.WriteLine("enter force type");
                string ForceType = Console.ReadLine();

                if (ForceType == "")
                {

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
