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
                var Movement = new MovementSelector();
                Movement.MovementSetup();
            }
        }
    }
}
