using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After
{
    internal class BankB : IBank
    {
        public string Withdraw()
        {
           return "Your Request Is Processing  By BankB";
        }
    }
}
