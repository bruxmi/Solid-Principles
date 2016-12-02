using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Start;

namespace Solid.OpenClosedPrinciple.AbstractMethods
{
    public class TradeProcessor : TradeProcessorAbstract
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
