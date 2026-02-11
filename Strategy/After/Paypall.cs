namespace Strategy.After
{
    internal class Paypall : IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Paypall");
        }
    }
}
