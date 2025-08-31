using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public Address address { get; set; }

        public override string ToString()
        {
            return $"Name of person is {this.Name} , Address is {this.address.Country} , {this.address.City}";
        }

        public Person DeepCopy()
        {
            Person person = (Person)this.MemberwiseClone();
            person.address = new Address
            {
                Country = address.Country,
                City = address.City,
            };
            return person;
          
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
