using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._03_OpenClosedPrinciple.InterfaceInheritance
{
    public interface ITradeProcessor
    {
        IEnumerable<string> GetTradeData();

        IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);

        void Persist(IEnumerable<TradeRecord> trades);
    }
}
