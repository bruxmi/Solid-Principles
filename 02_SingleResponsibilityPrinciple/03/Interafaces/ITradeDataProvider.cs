using System.Collections.Generic;

namespace Solid._02_SingleResponsibilityPrinciple._03.Interafaces
{
    public interface ITradeDataProvider
    {
        IEnumerable<string> GetTradeData();
    }
}
