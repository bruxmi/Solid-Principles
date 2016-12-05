namespace Solid._03_OpenClosedPrinciple.AbstractMethods
{
    public class TradeProcessorClient
    {
        private readonly TradeProcessorAbstract _tradeProcessor;
        public TradeProcessorClient(TradeProcessorAbstract tradeProcessor)
        {
            this._tradeProcessor = tradeProcessor;
        }

        public void ProcessTrades()
        {
            var lines = _tradeProcessor.GetTradeData();
            var trades = _tradeProcessor.Parse(lines);
            _tradeProcessor.Persist(trades);
        }
    }
}
