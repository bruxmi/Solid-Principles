using Solid._01_Start;

namespace Solid._02_SingleResponsibilityPrinciple._02.Interafaces
{
    public interface ITradeMapper
    {
        TradeRecord Map(string[] fields);
    }
}
