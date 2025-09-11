using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Factory : IFactory
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

        public IPaymentCard GetPaymentCard(string cardNumber)
        {
            switch (cardNumber)
            {
                case "12": return new VisaCard(); break;
                case "34": return new MasterCard(); break;
            }
            return null;
        }
    }
}
