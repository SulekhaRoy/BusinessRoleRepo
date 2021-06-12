using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Core.BusinessRules.Interface
{
    public interface IPayment
    {
        string GetPayment(string option);
    }
}
