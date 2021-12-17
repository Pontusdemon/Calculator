using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Movement
    {
        public void MovementSelector()
        {
            Console.WriteLine("select movement type");
            string MovementType = Console.ReadLine();

            if (MovementType == "velocity")
            {
                Console.WriteLine("select velocity type");
                string VelocityType = Console.ReadLine();

                if (VelocityType == "average")
                {
                    var AverageVelocity = new Velocity.Average();

                    Console.WriteLine("v = s / t");
                }

                else if (VelocityType == "timeless")
                {
                    var TimelessVelocity = new Velocity.Timeless();

                    Console.WriteLine("select timeless velocity type");
                    string TimelessVelocityType = Console.ReadLine();

                    if (TimelessVelocityType == "final")
                    {
                        Console.WriteLine("v = (x^2 + 2as)^0.5");
                    }

                    else if (TimelessVelocityType == "initial")
                    {
                        Console.WriteLine("x = (v^2 - 2as)^0.5");
                    }
                }
            }

            else if (MovementType == "acceleration")
            {

            }
        }
    }
}
