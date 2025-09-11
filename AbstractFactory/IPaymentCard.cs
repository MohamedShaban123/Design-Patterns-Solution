using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Product 2 

    internal interface IPaymentCard
    {
        public string GetName();
        public string GetProviderInfo();
    }

    public class VisaCard : IPaymentCard
    {
        public string GetName()
        {
            return "Visa Card";
        }

        public string GetProviderInfo()
        {
            return "Visa";
        }
    }

    public class MasterCard : IPaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string GetProviderInfo()
        {
            return "Master";
        }
    }
}
