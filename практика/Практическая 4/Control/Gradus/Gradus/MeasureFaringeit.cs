using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradus
{
    class MeasureFaringeit : IGrad
    {
        Random r;

        public MeasureFaringeit()
        {
            r = new Random();
        }

        public int Grad()
        {
            //Fandom number
            int res = r.Next(-100, 100);
            return res;
        }
    }
}
