﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Kost : IGame
    {
        Random r;

        public Kost()
        {
            r = new Random();
        }

        public int Brosok()
        {
            //Random number from 1 to 6.
            int res = r.Next(6) + 1;
            return res;
        }
    }
}
