using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradus
{
    class Measure
    {
        public string Name { get; set; }
        public Measure(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
        public int MeasureTemperature(IGrad ig)
        {
            return ig.Grad();
        }
    }
}
