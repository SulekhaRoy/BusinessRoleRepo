using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Core.BusinessRules.Interface;

namespace BusinessRules.Core.BusinessRules.BaseClass
{
    public abstract class Payment
    {
        public abstract IPayment FactoryMethod(string option);
               
    }
}
