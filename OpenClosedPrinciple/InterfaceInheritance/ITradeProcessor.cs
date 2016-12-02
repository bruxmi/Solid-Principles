using Solid.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.InterfaceInheritance
{
    public interface ITradeProcessor
    {
        IEnumerable<string> GetTradeData();

        IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);

        void Persist(IEnumerable<TradeRecord> trades);
    }
}
