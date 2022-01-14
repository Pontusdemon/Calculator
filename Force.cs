using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Force
    {
        public abstract void MasterForce();

        public class Pressure : Force
        {
            public override void MasterForce()
            {
                throw new NotImplementedException();
            }
        }

        // pressure
        // lift
        // force
        // forcemoment
        // Friktion
        // work
        // hookes law
    }
}
