using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Start;

namespace Solid.OpenClosedPrinciple.InterfaceInheritance
{
    public class TradeProcessor : ITradeProcessor
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
