using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public double Minus(double operand)
        {
            return Run(new Minus(arithmeticUnit, operand));
        }

        public double Mult(double operand)
        {
            return Run(new Mult(arithmeticUnit, operand));
        }

        public double Division(double operand)
        {
            return Run(new Division(arithmeticUnit, operand));
        }
    }
}
