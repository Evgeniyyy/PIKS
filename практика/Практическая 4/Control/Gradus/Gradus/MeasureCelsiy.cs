using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradus
{
    class MeasureCelsiy
    {
        Random r;
        public MeasureCelsiy()
        {
            r = new Random(); 
        }

        public int GradC()
        {
            int res = r.Next(-30, 30);
            return res;
        }

    }
}
