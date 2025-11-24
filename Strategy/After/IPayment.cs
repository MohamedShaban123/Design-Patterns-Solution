using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.After
{
    internal interface IPayment
    {
        public void Pay(decimal amount);
    }
}
