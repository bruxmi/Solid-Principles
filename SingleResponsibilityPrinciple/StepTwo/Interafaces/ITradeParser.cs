using Solid.Start;
using System.Collections.Generic;

namespace Solid.SingleResponsibilityPrinciple.StepTwo.Interfaces
{
    public interface ITradeParser
    {
        IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);
    }
}
