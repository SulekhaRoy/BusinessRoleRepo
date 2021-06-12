using BusinessRules.Core.BusinessRules.BaseClass;
using BusinessRules.Core.BusinessRules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Core
{
    class PhysicalProduct : IPayment
    {
        public string GetPayment(string option)
        {
            return "packing Slip For Shipping";
        }
    }
}
