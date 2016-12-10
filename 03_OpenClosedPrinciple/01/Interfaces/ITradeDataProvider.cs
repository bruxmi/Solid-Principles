using System.Collections.Generic;

namespace Solid._03_OpenClosedPrinciple._01.Interfaces
{
    public interface ITradeDataProvider
    {
        IEnumerable<string> GetTradeData();
    }
}
