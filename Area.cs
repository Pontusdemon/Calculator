using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Area
    {
        public class Pressure : Area
        {
            public double A;
            public double F;
            public double p;

            public void PressureArea()
            {
                A = F / p;
                Console.WriteLine("A = " + A);
            }
        }
    }
}