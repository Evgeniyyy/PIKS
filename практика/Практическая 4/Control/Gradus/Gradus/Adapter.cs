using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradus
{
    class Adapter : IGrad
    {
        MeasureCelsiy cel;
        public Adapter(MeasureCelsiy c)
        {
            cel = c;
        }

        public int Grad()
        {
            return cel.GradC();
        }
    }
}
