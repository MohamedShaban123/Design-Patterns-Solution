using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IFactory
    {
        public IBank GetBank(string bankCode);
        public IPaymentCard GetPaymentCard(string cardNumber);


    }
}
