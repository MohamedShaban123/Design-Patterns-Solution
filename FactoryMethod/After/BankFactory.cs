using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.After
{
    internal class BankFactory : IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456":return new BankA(); break;
                case "112233": return new BankB(); break;
            }
            return null;
        }
    }
}
