using FactoryMethod.After;
using FactoryMethod.Before;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Before

            //Problems with this approach

            //1) Tight coupling

            //The switch knows about all possible banks(BankA, BankB).

            //If you add BankC, you must modify this switch and add another case.

            //This violates the Open/ Closed Principle(should be open for extension, closed for modification).

            //2) Duplication of logic

            //Each time you need to decide “which bank?”, you’ll repeat the same switch.

            //That spreads logic everywhere instead of centralizing it.

            //3)No common abstraction

            //BankA and BankB don’t share an interface.

            //If later you want to treat them polymorphically(like IBank bank = ...; bank.Withdraw();), you can’t.

            // 4) Scalability issue

            //If your system grows from 2 banks to 20 banks, the switch will be a monster 😅.


            //BankA bankA = new BankA();
            //BankB bankB = new BankB();
            //Console.WriteLine("Enter Your Card Number : ");
            //var cardNumber = Console.ReadLine();    
            //var bankCode  = cardNumber.Substring(0,6);
            //switch (bankCode)
            //{
            //    case "123456": bankA.Withdraw(); break;
            //    case "112233": bankB.Withdraw(); break;
            //}

            #endregion

            //string bankNumber,bankCode;
            //Console.WriteLine("Please Inter Bank Number: ");
            //bankNumber = Console.ReadLine();
            //bankCode = bankNumber.Substring(0, 6);
            //BankFactory bankFactory = new BankFactory();
            //IBank bank= bankFactory.GetBank(bankCode);
            //var bankName= bank.Withdraw();
            //Console.WriteLine(bankName);






            #region After

            #endregion
        }
    }
}
