using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imagine you have a Bank Account Service(IBankAccount) that allows withdrawing money.
             But we don’t want everyone to directly access it — only authenticated users should be able to withdraw.
             We’ll use a Proxy that acts as a gatekeeper.
             */
            IBankAccount account1 = new BankAccountProxy("Customer", 1000);
            account1.Withdraw(200); // ✅ Allowed

            IBankAccount account2 = new BankAccountProxy("Guest", 1000);
            account2.Withdraw(200); // 🚫 Denied

        }
    }
}
