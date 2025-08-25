using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Counter
    {
        private static  Counter _instance;
        public static int counter { get; set; } = 0;

        public static object _lock  { get; set; } = new object();

        private Counter()
        {
            
        }


        public static Counter Instance {

            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Counter();
                    }
                    return _instance;
                }
                  
              
            }
        }

      

       public int  getCount()
        {
           return ++counter;
        }


      

    }
}
