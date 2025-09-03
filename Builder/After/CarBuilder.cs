using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.After
{
    internal class CarBuilder
    {
      private Car car = new Car();

       public CarBuilder SetEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }
        public CarBuilder SetWheels(int wheels)
        {
            car.Wheels=wheels;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            car.Color=color;
            return this;
        }

        public Car Build()
        {
            return car;
        }
    }
}
