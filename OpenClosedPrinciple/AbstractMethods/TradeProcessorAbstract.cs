using Solid.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.AbstractMethods
{
    public abstract class TradeProcessorAbstract
    {
        public abstract IEnumerable<string> GetTradeData();

        public abstract IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);

        public abstract void Persist(IEnumerable<TradeRecord> trades);
    }
}
