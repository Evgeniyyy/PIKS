using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Operation
    {
        public static double Run(char operationCode, int operand)
        {
            Log lg2 = Log.MyLog;
            double rez = 0;
            switch (operationCode)
            {
                case '+':
                    rez += operand;
                    lg2.LogExecution("Slozhenie " + operand);
                    break;

                case '-':
                    rez -= operand;
                    lg2.LogExecution("Vichitanie " + operand);
                    break;
                case '*':
                    rez *= operand;
                    break;
                case '/':
                case ':':
                    rez /= operand;
                    break;
            }
            return rez;
        }
    }
}
