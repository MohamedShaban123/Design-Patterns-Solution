namespace Strategy.After
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
        }
    }
}
