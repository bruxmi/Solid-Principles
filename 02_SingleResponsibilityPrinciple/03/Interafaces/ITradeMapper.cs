using Solid._01_Start;

namespace Solid._02_SingleResponsibilityPrinciple._03.Interafaces
{
    public interface ITradeMapper
    {
        TradeRecord Map(string[] fields);
    }
}
