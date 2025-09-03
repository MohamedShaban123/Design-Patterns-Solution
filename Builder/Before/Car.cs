using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Before
{
    internal class Car
    {
       
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }


        public Car(string engine, int wheels, string color)
        {
            Engine = engine;
            Wheels = wheels;
            Color = color;
        }


    }
}
