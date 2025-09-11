using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After
{
    internal class BankA : IBank
    {
        public string Withdraw()
        {
            return "Your Request Is Processing  By BankA";
        }
    }
}
