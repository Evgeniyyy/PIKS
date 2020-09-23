using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber
{
    abstract class Progression
    {
        public bool HairCut { get; set; }
        public bool HairColor { get; set; }
        public bool  HairWashing { get; set; }

        public int time;

        public Progression(bool hc, bool hcl, bool hw)
        {
            HairCut = hc;
            HairColor = hcl;
            HairWashing = hw;
        }

        public void TemplateMethod()
        {
            InitProgression(HairCut, HairColor, HairWashing);
            Progress();
            Print(time);
        }

        private void Print(int time)
        {
            Console.WriteLine("Session time {0} min", time);
            Console.WriteLine();
        }

        private void InitProgression(bool a, bool b, bool c)
        {
            HairCut = a;
            HairColor = b;
            HairWashing = c;
        }

        public abstract void Progress();
    }
}
