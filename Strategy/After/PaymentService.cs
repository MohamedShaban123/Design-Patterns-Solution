using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.After
{
    internal class PaymentService
    {
        private readonly IPayment _payment;

        public PaymentService(IPayment payment)
        {
            this._payment = payment;
        }

        public void Pay(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
}
