namespace Strategy.Before
{
    internal class CreditCard
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using CreditCard");
        }
    }
}
