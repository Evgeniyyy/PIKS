using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Monet
    {
        Random r;

            public Monet()
        {
            r = new Random();
        }

        public int BrosokM()
        {
            //Random number from 1 to 2.
            int res = r.Next(2) + 1;
            return res;
        }
    }
}
