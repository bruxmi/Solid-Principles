using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._03_OpenClosedPrinciple.AbstractMethods
{
    public abstract class TradeProcessorAbstract
    {
        public abstract IEnumerable<string> GetTradeData();

        public abstract IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);

        public abstract void Persist(IEnumerable<TradeRecord> trades);
    }
}
