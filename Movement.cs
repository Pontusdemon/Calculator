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

                        Console.WriteLine("enter initial velocity");
                        TimelessVelocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        TimelessVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter distance");
                        TimelessVelocity.s = Convert.ToDouble(Console.ReadLine());

                        TimelessVelocity.VelocityMaster();
                    }

                    else if (TimelessVelocityType == "initial")
                    {
                        Console.WriteLine("x = (v^2 - 2as)^0.5");

                        Console.WriteLine("enter velocity");
                        TimelessVelocity.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        TimelessVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter distance");
                        TimelessVelocity.s = Convert.ToDouble(Console.ReadLine());

                        TimelessVelocity.InitialTimelssVelocity();
                    }
                }

                else if (VelocityType == "velocity by distance")
                {
                    var VelocityByDistance = new Velocity.VelocityByDistance();

                    Console.WriteLine("select final or initial velocity");
                    string SelectVelocity = Console.ReadLine();

                    if (SelectVelocity == "final")
                    {
                        var GetCalculation = new Velocity.Timeless();

                        Console.WriteLine("enter initial velocity");
                        GetCalculation.u = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        GetCalculation.t = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter accelerartion");
                        GetCalculation.a = Convert.ToDouble(Console.ReadLine());

                        GetCalculation.VelocityMaster();
                    }

                    else if (SelectVelocity == "initial")
                    {
                        Console.WriteLine("u = s / t - at / 2");

                        Console.WriteLine("enter distance");
                        VelocityByDistance.s = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        VelocityByDistance.t = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        VelocityByDistance.a = Convert.ToDouble(Console.ReadLine());

                        VelocityByDistance.VelocityMaster();
                    }
                }
            }

            else if (MovementType == "acceleration")
            {
                Console.WriteLine("select acceleration type");
                string AccelerationType = Console.ReadLine();

                if (AccelerationType == "acceleration")
                {
                    Console.WriteLine("a = (v - x) / t");

                    Console.WriteLine("enter velocity");

                }
            }
        }
    }
}
