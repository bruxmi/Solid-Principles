using System;
using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._03_OpenClosedPrinciple.InterfaceInheritance
{
    public class TradeProcessorAudit : ITradeProcessor
    {
        public IEnumerable<string> GetTradeData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData)
        {
            throw new NotImplementedException();
        }

        public void Persist(IEnumerable<TradeRecord> trades)
        {
            throw new NotImplementedException();
        }
    }
}
