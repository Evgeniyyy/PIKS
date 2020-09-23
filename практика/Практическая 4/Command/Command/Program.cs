using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = 0;
            result = calculator.Add(5);
            Console.WriteLine(result);

            result = calculator.Add(4);
            Console.WriteLine(result);

            result = calculator.Add(3);
            Console.WriteLine(result);

            result = calculator.Minus(8);
            Console.WriteLine(result);

            result = calculator.Mult(5);
            Console.WriteLine(result);

            result = calculator.Minus(3);
            Console.WriteLine(result);

            result = calculator.Division(2);
            Console.WriteLine(result);

            /*result = calculator.Redo(1);
            Console.WriteLine(result);

            result = calculator.Undo(1);
            Console.WriteLine(result);*/
        }
    }
}
