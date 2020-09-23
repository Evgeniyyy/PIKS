using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AutoBase
    {
        public string Name { get; set; }
        public string Description { get; set; }    
        public double CostBase { get; set; }

        public abstract double GetCost();

        public override string ToString()
        {
            string s =String.Format("Your car: \n{0}  \n discription: {1} \n Cost {2}\n",
                Name, Description, GetCost());
        return s;
        }
    }
}
