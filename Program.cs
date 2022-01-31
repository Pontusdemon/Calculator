using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select subject");
            string Subject = Console.ReadLine();

            if (Subject == "movement")
            {
                var GetMovement = new Movement();
                GetMovement.MovementSelector();
            }

            else if (Subject == "thermophysics")
            {
                var GetThermophysics = new Thermophysics();
                GetThermophysics.ThermophysicsSelector();
            }

            else if (Subject == "force and energy")
            {
                var GetForceEnergy = new ForceEnergy();
                GetForceEnergy.ForceEnergySetup();
            }
        }
    }
}
