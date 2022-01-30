using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Temperature
    {
        // T = (p * V) / k;

        public double T;
        public double p;
        public double V;
        public double k;

        public void TemperatureByGeneralGaslaw()
        {
            T = (p * V) / k;
            Console.WriteLine("T = " + T);
        }
    }
}
