using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber
{
    class Client : Progression
    {
        public Client(bool a, bool b, bool c) : base(a,b,c) { }
        public override void Progress()
        {
            bool hc = HairCut;
            bool hcl = HairColor;
            bool hw = HairWashing;

            if (hc == true)
            {
                time = time + 20;
            }
            if (hcl == true)
            {
                time = time + 60;
            }
            if (hw == true)
            {
                time = time + 10;
            }

        }
    }
}
