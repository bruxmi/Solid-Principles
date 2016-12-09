using Solid._02_SingleResponsibilityPrinciple._03.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple
{
    /// <summary>
    /// The class models the process of transferring trade data from one format to another. This is its only
    /// responsibility, its only concern, and the only reason that this class should change.
    /// </summary>
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
