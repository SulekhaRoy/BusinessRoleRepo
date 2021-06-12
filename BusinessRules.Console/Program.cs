using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Core;
using BusinessRules.Core.BusinessRules.BaseClass;
using BusinessRules.Core.BusinessRules;
using BusinessRules.Core.BusinessRules.Interface;

namespace BusinessRules.Console
{
    class Program
    {
        //Factory pattern Demo
        static void Main(string[] args)
        {
            Payment factory = new ConcretePaymentFactory();
            IPayment payment = factory.FactoryMethod("book");

        }

    }
}
