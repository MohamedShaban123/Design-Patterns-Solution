namespace Strategy.After
{
    internal class CreditCard : IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using CreditCard");
        }
    }
}
