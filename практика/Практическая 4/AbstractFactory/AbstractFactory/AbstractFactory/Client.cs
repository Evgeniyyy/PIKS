using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstractKuzov abstractkuzov;

        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            abstractkuzov = car_factory.CreateKuzov();
        }

        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }
 
        public string KuzovAuto()
        {
            return abstractkuzov.kuzov;
        }

        public override string ToString()
        {
            return abstractCar.ToString();
        }
    }
}
