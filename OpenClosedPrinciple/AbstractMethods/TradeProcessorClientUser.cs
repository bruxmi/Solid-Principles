using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.AbstractMethods
{
    public class TradeProcessorClientUser
    {
        public void UseTradeProcessorClient()
        {
            var tradeProcessorClient1 = new TradeProcessorClient(new TradeProcessor());
            tradeProcessorClient1.ProcessTrades();
            var tradeProcessorClient2 = new TradeProcessorClient(new TradeProcessorVersion2());
            tradeProcessorClient2.ProcessTrades();
        }
    }
}
