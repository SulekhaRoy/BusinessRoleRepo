using BusinessRules.Core.BusinessRules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Core.BusinessRules.BaseClass
{
    public class ConcretePaymentFactory : Payment
    {      

        public override IPayment FactoryMethod(string option)
        {
            switch (option)
            {
                case "Book":
                    return new Book();
                case "Upgrade":
                    return new Upgrade();
                case "Video":
                    return new Video();
                case "Membsership":
                    return new Membership();
                default:
                    return new Book();
            }
        }
    }
   
}
