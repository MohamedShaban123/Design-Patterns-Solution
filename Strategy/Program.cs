<<<<<<< HEAD
﻿namespace Strategy
=======
﻿using Strategy.After;
using Strategy.Before;

namespace Strategy
>>>>>>> e0afb4346430e7a6b5ed5099e33cdab4472f87f1
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            #region Before
            //var paymentServie1 = new Before.PaymentService();
            //paymentServie1.Pay("test", 1000);
            //var paymentServie2 = new Before.PaymentService();
            //paymentServie2.Pay("creditcard", 1000);
            //var paymentServie3 = new Before.PaymentService();
            //paymentServie3.Pay("paypall", 1000);
            #endregion




            #region After
            //var payment1 = new After.PaymentService(new After.CreditCard());
            //payment1.pay(2000);
            //var payment2 = new After.PaymentService(new After.Paypall());
            //payment2.pay(2000);
=======
            #region Before Strategy Pattern
            //var paymentService1 = new Before.PaymentService();
            //paymentService1.Pay(100, "CreditCard");
            //paymentService1.Pay(200, "PayPal");
            //paymentService1.Pay(50, "Cash");
            #endregion

            #region After Strategy Pattern

            //var paymentService2 =  new After.PaymentService(new CashPayment());
            //paymentService2.Pay(100);
            //var paymentService3 = new After.PaymentService(new PayPalPayment());
            //paymentService3.Pay(200);
            //var paymentService4 = new After.PaymentService(new CreditCardPayment());
            //paymentService4.Pay(50);

>>>>>>> e0afb4346430e7a6b5ed5099e33cdab4472f87f1
            #endregion
        }
    }
}
