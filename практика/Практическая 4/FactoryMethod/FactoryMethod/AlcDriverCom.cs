using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class AlcDriverCom : TransportCompany
    {
        public AlcDriverCom(string name) : base(name) { }

        public override TransportService Create(string n, int k)
        {
            return new AlcDriver(Name, k);
        }
    }
}
