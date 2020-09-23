using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class AlcDriver : TransportService
    {
        public double Tariff { get; set; }

        public AlcDriver(string name, int taff): base(name)
        {
            Tariff = taff;
        }

        public override double CostTransportation(double distance)
        {
            return distance * Tariff;
        }

        public override string ToString()
        {
            string s = String.Format("Firm {0}, arrived via tariff {1}",
                Name, Tariff);
            return s;
        }
    }
}
