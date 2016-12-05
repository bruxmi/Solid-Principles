using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._02_SingleResponsibilityPrinciple._02.Interafaces
{
    public interface ITradeParser
    {
        IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);
    }
}
