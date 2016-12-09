using Solid._01_Start;
using Solid._02_SingleResponsibilityPrinciple._03.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple._03.Services
{
    public class SimpleTradeMapper : ITradeMapper
    {
        private static float LotSize = 100000f;

        public TradeRecord Map(string[] fields)
        {
            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);
            var tradeAmount = int.Parse(fields[1]);
            var tradePrice = decimal.Parse(fields[2]);
            var tradeRecord = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };
            return tradeRecord;
        }
    }
}
