using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilityPrinciple.StepTwo.Interafaces
{
    public interface ITradeValidator
    {
        bool Validate(string[] fields);
    }
}
