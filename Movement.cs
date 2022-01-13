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
            var VelocityInputSetup = new VelocitySetup();

            Console.WriteLine("select movement type");
            string MovementType = Console.ReadLine();

            if (MovementType == "velocity")
            {
                Console.WriteLine("select velocity type");
                string VelocityType = Console.ReadLine();

                if (VelocityType == "average")
                {
                    Console.WriteLine("v = s / t");

                    var AverageVelocity = new Velocity.Average();
                    AverageVelocity.VelocityMaster();
                }

                else if (VelocityType == "general")
                {
                    var GeneralVelocity = new Velocity.Master();

                    Console.WriteLine("select inital or final velocity");
                    string SelectVelocity = Console.ReadLine();

                    if (SelectVelocity == "final")
                    {
                        Console.WriteLine("v = x + a * t");

                        Console.WriteLine(VelocityInputSetup.new_x);
                        GeneralVelocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(VelocityInputSetup.new_a);
                        GeneralVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(VelocityInputSetup.new_t);
                        GeneralVelocity.t = Convert.ToDouble(Console.ReadLine());

                        GeneralVelocity.VelocityMaster();
                    }
                }

                else if (VelocityType == "timeless")
                {
                    Console.WriteLine("select initial or final velocity");
                    string SelectVelocity = Console.ReadLine();

                    var TimelessVelocity = new Velocity.Timeless();

                    if (SelectVelocity == "final")
                    {
                        Console.WriteLine("v = (x^2 + 2as)^0.5");

                        Console.WriteLine(VelocityInputSetup.new_x);
                        TimelessVelocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(VelocityInputSetup.new_a);
                        TimelessVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(VelocityInputSetup.new_s);
                        TimelessVelocity.s = Convert.ToDouble(Console.ReadLine());
                    }

                    else if (SelectVelocity == "initial")
                    {
                        Console.WriteLine("x = (v^2 - 2as)^0.5");

                        Console.WriteLine(VelocityInputSetup.new_v);
                        TimelessVelocity.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(VelocityInputSetup.new_a);
                        TimelessVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(VelocityInputSetup.new_s);
                        TimelessVelocity.s = Convert.ToDouble(Console.ReadLine());
                    }
                }

                else if (VelocityType == "velocity by distance")
                {
                    var VelocityByDistance = new Velocity.VelocityByDistance();

                    Console.WriteLine("select final or initial velocity");
                    string VelocityByDistanceType = Console.ReadLine();

                    if (VelocityByDistanceType == "final")
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

                    else if (VelocityByDistanceType == "initial")
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
                var Acceleration = new Acceleration();

                Console.WriteLine("select acceleration type");
                string AccelerationType = Console.ReadLine();

                if (AccelerationType == "general")
                {
                    Console.WriteLine("a = (v - x) / t");

                    Console.WriteLine("enter velocity");
                    Acceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Acceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    Acceleration.t = Convert.ToDouble(Console.ReadLine());

                    Acceleration.GeneralAcceleration();
                }

                else if (AccelerationType == "timeless acceleration")
                {
                    Console.WriteLine("a = (v^2 - x^2) / 2s");

                    Console.WriteLine("enter velocity");
                    Acceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Acceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    Acceleration.s = Convert.ToDouble(Console.ReadLine());
                }

                else if (AccelerationType == "acceleration by distance")
                {
                    Console.WriteLine("a = 2(s - ut) / t^2");

                    Console.WriteLine("enter distance");
                    Acceleration.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Acceleration.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    Acceleration.t = Convert.ToDouble(Console.ReadLine());
                }
            }

            else if (MovementType == "distance")
            {
                Console.WriteLine("select how to calculate distance");
                string DistanceCalculation = Console.ReadLine();
                var Distance = new Distance();

                if (DistanceCalculation == "by average velocity")
                {
                    Console.WriteLine("s = v * t");

                    Console.WriteLine("enter velocity");
                    Distance.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    Distance.t = Convert.ToDouble(Console.ReadLine());

                    Distance.DistanceByAverageVelocity();
                }

                else if (DistanceCalculation == "timeless")
                {
                    Console.WriteLine("s = (v^2 + x^2) / 2a");

                    Console.WriteLine("enter velocity");
                    Distance.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Distance.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    Distance.a = Convert.ToDouble(Console.ReadLine());

                    Distance.TimelessDistance();
                }

                else
                {
                    Console.WriteLine("s = ut + (at^2) / 2");

                    Console.WriteLine("enter initial velocity");
                    Distance.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    Distance.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    Distance.a = Convert.ToDouble(Console.ReadLine());

                    Distance.DistanceDistance();
                }
            }

            else if (MovementType == "time")
            {
                Console.WriteLine("select movement time");
                string TimeCalculation = Console.ReadLine();
                var Time = new Time();

                if (TimeCalculation == "by average velocity")
                {
                    Console.WriteLine("t = s / v");

                    Console.WriteLine("enter distance");
                    Time.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter velocity");
                    Time.v = Convert.ToDouble(Console.ReadLine());

                    Time.TimeByAverageVelocity();
                }

                else if (TimeCalculation == "by acceleration")
                {
                    Console.WriteLine("t = (v - x) / a");

                    Console.WriteLine("enter velocity");
                    Time.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Time.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("entter acceleration");
                    Time.a = Convert.ToDouble(Console.ReadLine());

                    Time.TimeByAcceleration();
                }

                else if (TimeCalculation == "by distance")
                {
                    Console.WriteLine("t = (-u + (u^2 + 2as)^0.5) /a");

                    Console.WriteLine("enter initial velocity");
                    Time.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    Time.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    Time.s = Convert.ToDouble(Console.ReadLine());

                    Time.TimeByDistance();
                }
            }
        }
    }
}
