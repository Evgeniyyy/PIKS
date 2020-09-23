using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    class Drive
    {
        public event EventHandler driveevent;

        public string twist;

        public string Twist
        {
            get { return twist; }
            set
            {
                twist = value;

                if (driveevent != null)
                    driveevent(this, new EventArgs());
            }
        }

        public Drive()
        {
            Twist = "Start posision";
        }

        public void TurlLeft()
        {
            Twist = "Turn left";
        }

        public void TurlRight()
        {
            Twist = "Turn Right";
        }

        public void Stop()
        {
            Twist = "Stop";
        }

        public override string ToString()
        {
            string s = String.Format("Privod: {0}", Twist);
            return s;
        }
    }
}
