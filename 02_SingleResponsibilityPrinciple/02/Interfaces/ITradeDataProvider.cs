using System.Collections.Generic;

namespace Solid._02_SingleResponsibilityPrinciple._02.Interfaces
{
    public interface ITradeDataProvider
    {
        IEnumerable<string> GetTradeData();
    }
}
