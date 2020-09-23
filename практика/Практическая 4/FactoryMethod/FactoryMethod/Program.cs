
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Taxi Service");
            TransportService compService = trCom.Create("Taxi", 1);

            double dist = 15.5;
            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Shipping Service");
            compService = gCom.Create("Shipping", 2);

            double distg = 150.5;
            Print(compService, distg);

            TransportCompany alcCom = new AlcDriverCom("Drunked driver");
            compService = alcCom.Create("Drunked driver", 3);
            double distal = 100.5;
            Print(compService, distal);
        }

        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Company {0}, distance {1}, cost: {2} ",
                compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}
