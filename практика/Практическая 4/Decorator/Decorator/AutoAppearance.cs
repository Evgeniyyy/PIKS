using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AutoAppearance : DecoratorOptions
    {
        public AutoAppearance(AutoBase p , string t) : base(p,t)
        {
            AutoProperty = p;

            Name = p.Name + "Extarier";
            Description = p.Description + ". " + this.Title +
                ". Dark style packet";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 649.99;
        }
    }
}
