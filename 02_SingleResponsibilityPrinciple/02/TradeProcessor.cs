using Solid._02_SingleResponsibilityPrinciple._02.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple._02
{
    public class TradeProcessor
    {
        private readonly ITradeDataProvider _tradeDataProvider;
        private readonly ITradeParser _tradeParser;
        private readonly ITradeStorage _tradeStorage;

        public TradeProcessor(ITradeDataProvider tradeDataProvider, ITradeParser tradeParser, ITradeStorage tradeStorage)
        {
            this._tradeDataProvider = tradeDataProvider;
            this._tradeParser = tradeParser;
            this._tradeStorage = tradeStorage;
        }

        public void ProcessTrades()
        {
            var lines = this._tradeDataProvider.GetTradeData();
            var trades = this._tradeParser.Parse(lines);
            this._tradeStorage.Persist(trades);
        }
    }
}
