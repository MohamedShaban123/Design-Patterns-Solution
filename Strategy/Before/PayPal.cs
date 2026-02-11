namespace Strategy.Before
{
    internal class PayPal
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal");
        }
    }
}
