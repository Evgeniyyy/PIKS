using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Mult : Command
    {
        public Mult(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('*', operand);

        }
        public override void UnExecute()
        {
            unit.Run('/', operand);
        }

    }
}
