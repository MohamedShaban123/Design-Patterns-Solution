using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class RealBankAccount : IBankAccount
    {
        private double _Balance { get; set; }

        public RealBankAccount(double balance)
        {
            _Balance = balance;
        }

        public void Withdraw(double amount)
        {
            if(amount <=_Balance) 
            {
                _Balance = _Balance - amount;
            Console.WriteLine($"✅ Withdrawal successful: {amount}, Remaining Balance: {_Balance}");
            }
            else
            {
                Console.WriteLine("❌ Insufficient funds!");

            }

        }
    }
}
