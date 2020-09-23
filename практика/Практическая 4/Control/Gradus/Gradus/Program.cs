using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradus
{
    class Program
    {
        static void Main(string[] args)
        {
            MeasureFaringeit far = new MeasureFaringeit();
            Measure m1 = new Measure("Fahrenheit: ");
            Console.WriteLine("{0}  {1} deg", m1.ToString(),m1.MeasureTemperature(far));
            MeasureCelsiy cel = new MeasureCelsiy();
            Measure m2 = new Measure("Celcies: ");
            IGrad measCel = new Adapter(cel);
            Console.WriteLine("{0} {1} deg", m2.ToString(),m2.MeasureTemperature(measCel));
        }
    }
}
