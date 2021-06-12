using BusinessRules.Core.BusinessRules.BaseClass;
using BusinessRules.Core.BusinessRules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Core
{
    public class Book : IPayment
    {
        public string GetPayment(string option)
        {
            return "duplicate packing slip for the royalty department";
        }

      
    }
}
