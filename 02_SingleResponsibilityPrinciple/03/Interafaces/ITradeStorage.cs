using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._02_SingleResponsibilityPrinciple._03.Interafaces
{
    public interface ITradeStorage
    {
        void Persist(IEnumerable<TradeRecord> trades);
    }
}
