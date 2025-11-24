using Strategy.After;
using Strategy.Before;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            #endregion
        }
    }
}
