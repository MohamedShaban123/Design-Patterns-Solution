using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class BankAccountProxy : IBankAccount
    {
        private string _userRole;
        private RealBankAccount _realBankAccount;
        public BankAccountProxy(string userRole, double initialBalance)
        {
            _userRole = userRole;
            _realBankAccount = new RealBankAccount(initialBalance);
        }

        public void Withdraw(double amount)
        {
            if(_userRole == "Admin" ||  _userRole =="Customer")
            {
                _realBankAccount.Withdraw(amount);
                Console.WriteLine($"🔑 Access granted for {_userRole}");
            }
            else
            {
                Console.WriteLine($"🚫 Access denied for {_userRole}");

            }
        }
    }
}
