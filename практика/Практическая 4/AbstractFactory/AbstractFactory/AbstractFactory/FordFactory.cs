﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Ford");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }

        public override AbstractKuzov CreateKuzov()
        {
            return new FordKuzov();
        }
    }
}
