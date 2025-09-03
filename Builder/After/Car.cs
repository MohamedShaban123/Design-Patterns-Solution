using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.After
{
    internal class Car
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Car engine is {Engine} , Number of wheels is {Wheels} , Color is {Color}";
        }
    }
}
