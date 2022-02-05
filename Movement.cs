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
            var InputSetup = new ProgramSetup();

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

                    Console.WriteLine(InputSetup.new_s);
                    AverageVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_t);
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

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

                        Console.WriteLine(InputSetup.new_x);
                        GeneralVelocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_a);
                        GeneralVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_t);
                        GeneralVelocity.t = Convert.ToDouble(Console.ReadLine());

                        GeneralVelocity.VelocityMaster();
                    }

                    else if (SelectVelocity == "initial")
                    {
                        Console.WriteLine("x = v - a * t");

                        Console.WriteLine(InputSetup.new_v);
                        GeneralVelocity.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_a);
                        GeneralVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_t);
                        GeneralVelocity.t = Convert.ToDouble(Console.ReadLine());

                        GeneralVelocity.InitialVelocity();
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

                        Console.WriteLine(InputSetup.new_x);
                        TimelessVelocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_a);
                        TimelessVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_s);
                        TimelessVelocity.s = Convert.ToDouble(Console.ReadLine());

                        TimelessVelocity.VelocityMaster();
                    }

                    else if (SelectVelocity == "initial")
                    {
                        Console.WriteLine("x = (v^2 - 2as)^0.5");

                        Console.WriteLine(InputSetup.new_v);
                        TimelessVelocity.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_a);
                        TimelessVelocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(InputSetup.new_s);
                        TimelessVelocity.s = Convert.ToDouble(Console.ReadLine());

                        TimelessVelocity.InitialTimelssVelocity();
                    }
                }

                else if (VelocityType == "initial velocity by distance")
                {
                    var InitialVelocityByDistance = new Velocity.VelocityByDistance();

                    Console.WriteLine("u = s/t - at/2");

                    Console.WriteLine(InputSetup.new_s);
                    InitialVelocityByDistance.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_t);
                    InitialVelocityByDistance.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_a);
                    InitialVelocityByDistance.a = Convert.ToDouble(Console.ReadLine());

                    InitialVelocityByDistance.VelocityMaster();
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

                    Console.WriteLine(InputSetup.new_v);
                    Acceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_x);
                    Acceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_t);
                    Acceleration.t = Convert.ToDouble(Console.ReadLine());

                    Acceleration.GeneralAcceleration();
                }

                else if (AccelerationType == "timeless acceleration")
                {
                    Console.WriteLine("a = (v^2 - x^2) / 2s");

                    Console.WriteLine(InputSetup.new_v);
                    Acceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_x);
                    Acceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_s);
                    Acceleration.s = Convert.ToDouble(Console.ReadLine());

                    Acceleration.TimelessAcceleration();
                }

                else if (AccelerationType == "acceleration by distance")
                {
                    Console.WriteLine("a = 2(s - ut) / t^2");

                    Console.WriteLine(InputSetup.new_s);
                    Acceleration.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_u);
                    Acceleration.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_t);
                    Acceleration.t = Convert.ToDouble(Console.ReadLine());

                    Acceleration.AccelerationByDistance();
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

                    Console.WriteLine(InputSetup.new_v);
                    Distance.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_t);
                    Distance.t = Convert.ToDouble(Console.ReadLine());

                    Distance.DistanceByAverageVelocity();
                }

                else if (DistanceCalculation == "timeless")
                {
                    Console.WriteLine("s = (v^2 + x^2) / 2a");

                    Console.WriteLine(InputSetup.new_v);
                    Distance.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_x);
                    Distance.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_a);
                    Console.WriteLine("if a = g then enter 9.82");
                    Distance.a = Convert.ToDouble(Console.ReadLine());

                    Distance.TimelessDistance();
                }

                else if (DistanceCalculation == "distance")
                {
                    Console.WriteLine("s = ut + (at^2) / 2");

                    Console.WriteLine(InputSetup.new_u);
                    Distance.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_t);
                    Distance.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_a);
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

                    Console.WriteLine(InputSetup.new_s);
                    Time.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_v);
                    Time.v = Convert.ToDouble(Console.ReadLine());

                    Time.TimeByAverageVelocity();
                }

                else if (TimeCalculation == "by acceleration")
                {
                    Console.WriteLine("t = (v - x) / a");

                    Console.WriteLine(InputSetup.new_v);
                    Time.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_x);
                    Time.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_a);
                    Console.WriteLine("if a = g then enter 9.82");
                    Time.a = Convert.ToDouble(Console.ReadLine());

                    Time.TimeByAcceleration();
                }

                else if (TimeCalculation == "by distance")
                {
                    Console.WriteLine("t = (-u + (u^2 + 2as)^0.5) /a");

                    Console.WriteLine(InputSetup.new_u);
                    Time.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_a);
                    Time.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(InputSetup.new_s);
                    Time.s = Convert.ToDouble(Console.ReadLine());

                    Time.TimeByDistance();
                }
            }
        }
    }
}
