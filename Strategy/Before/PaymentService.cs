using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Before
{
    internal class PaymentService
    {
        public void Pay(decimal amount,string paymentType)
        {
            if (paymentType == "CreditCard")
            {
                Console.WriteLine($"Paid {amount} using Credit Card.");
            }
            else if (paymentType == "PayPal")
            {
                Console.WriteLine($"Paid {amount} using PayPal.");
            }
            else if (paymentType == "Cash")
            {
                Console.WriteLine($"Paid {amount} using Cash.");
            }
            else
            {
                Console.WriteLine("Unknown payment type!");
            }
        }
    }
}
