using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("RENAULT", "Renault Logan Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Navigation");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Navigation"), "Security");
            Print(newmyReno);
            Console.WriteLine();

            Audi audi = new Audi("Audi ", "Audi S5 Sportback ", 69999.0);
            Print(audi);
            AutoBase myaudi = new AutoAppearance(audi, "Appearance ");
            Print(myaudi);
            AutoBase newmyaudi = new SystemSecurity(new AutoAppearance(audi, "Appearance "), "Security ");
            Print(newmyaudi);
        }

        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}
