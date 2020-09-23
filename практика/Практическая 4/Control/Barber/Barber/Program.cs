using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression pr1 = new Client(false, true, true);
            pr1.TemplateMethod();
            Progression pr2 = new Client(true, false, true);
            pr2.TemplateMethod();
        }
    }
}
