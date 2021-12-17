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

                    Console.WriteLine("enter distance");
                    AverageVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.VelocityMaster();
                }

                else if (VelocityType == "velocity")
                {
                    var Velocity = new Velocity.Master();

                    Console.WriteLine("press v for velocity, press x for intial velocity");
                    string VelocityOption = Console.ReadLine();

                    if (VelocityOption == "v")
                    {
                        Console.WriteLine("v = x + at");

                        Console.WriteLine("enter initial velocity");
                        Velocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        Velocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        Velocity.t = Convert.ToDouble(Console.ReadLine());

                        Velocity.VelocityMaster();
                    }

                    else if (VelocityOption == "x")
                    {
                        Console.WriteLine("x = v - at");

                        Console.WriteLine("enter velocity");
                        Velocity.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        Velocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        Velocity.t = Convert.ToDouble(Console.ReadLine());

                        Velocity.InitialVelocity();
                    }
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
