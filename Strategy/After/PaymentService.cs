<<<<<<< HEAD
﻿namespace Strategy.After
{
    internal class PaymentService
    {
        private readonly IPayment payment;

        public PaymentService(IPayment payment)
        {
            this.payment = payment;
        }


        public void pay(decimal amount)
        {
            this.payment.pay(amount);
=======
﻿using System;
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
>>>>>>> e0afb4346430e7a6b5ed5099e33cdab4472f87f1
        }
    }
}
