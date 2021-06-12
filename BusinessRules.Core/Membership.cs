using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRules.Core.BusinessRules.BaseClass;
using BusinessRules.Core.BusinessRules.Interface;

namespace BusinessRules.Core
{
    public class Membership:IPayment
    {
        public string GetPayment(string option)
        {
            return "activate the membership";
        }

       
    }
}
