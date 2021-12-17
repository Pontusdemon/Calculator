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
                var Movement = new Movement();
                Movement.MovementSelector();
            }

            else if (Subject == "thermophysics")
            {

            }
        }
    }
}
