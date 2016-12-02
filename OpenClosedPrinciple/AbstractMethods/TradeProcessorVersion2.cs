using System;
using System.Collections.Generic;
using Solid.Start;

namespace Solid.OpenClosedPrinciple.AbstractMethods
{
    public class TradeProcessorVersion2 : TradeProcessorAbstract
    {
        public override IEnumerable<string> GetTradeData()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData)
        {
            throw new NotImplementedException();
        }

        public override void Persist(IEnumerable<TradeRecord> trades)
        {
            throw new NotImplementedException();
        }
    }
}
