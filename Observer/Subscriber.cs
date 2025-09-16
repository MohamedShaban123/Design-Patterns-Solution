using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Subscriber
    internal class Subscriber 
    {
        public string Name { get; }

        public Subscriber(string name) => Name = name;

        public void OnVideoUploaded(string title)
        {
            Console.WriteLine($"{Name} received notification: {title}");
        }
    }
}
