using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Product 1
    internal interface IBank
    {
        public string Withdraw();
    }


    internal class BankA : IBank
    {
        public string Withdraw()
        {
            return "Your Request Is Processing  By BankA";
        }
    }

    internal class BankB : IBank
    {
        public string Withdraw()
        {
            return "Your Request Is Processing  By BankB";
        }
    }
}
