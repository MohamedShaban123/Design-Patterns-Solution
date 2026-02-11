namespace Strategy.Before
{
    internal class PaymentService
    {

        public void Pay(string type, decimal amount)
        {
            if (type == "creditcard")
            {
                new CreditCard().Pay(amount);
            }
            else if (type == "paypall")
            {
                new PayPal().Pay(amount);
            }
            else
            {
                Console.WriteLine("Wrong payment type");
            }

        }
    }
}
