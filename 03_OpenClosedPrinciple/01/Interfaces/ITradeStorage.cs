using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._03_OpenClosedPrinciple._01.Interfaces
{
    public interface ITradeStorage
    {
        void Persist(IEnumerable<TradeRecord> trades);
    }
}
