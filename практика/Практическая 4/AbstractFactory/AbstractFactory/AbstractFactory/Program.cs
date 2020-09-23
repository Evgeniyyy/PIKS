using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);

            Console.WriteLine("Kuzov: {0}    Max speed {1} is {2} km/hour", c1.KuzovAuto(), c1.ToString(), c1.RunMaxSpeed());

            CarFactory audi_car = new AudiFactory();
            Client c2 = new Client(audi_car);
            Console.WriteLine("Kuzov: {0}    Max speed {1} is {2} km/hour ", c2.KuzovAuto(), c2.ToString(), c2.RunMaxSpeed());
        }
    }
}
