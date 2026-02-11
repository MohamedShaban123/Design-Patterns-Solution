namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            #endregion
        }
    }
}
