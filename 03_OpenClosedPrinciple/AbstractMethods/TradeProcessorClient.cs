namespace Solid._03_OpenClosedPrinciple.AbstractMethods
{
    public class TradeProcessorClient
    {
        private readonly TradeProcessorAbstract tradeProcessor;
        public TradeProcessorClient(TradeProcessorAbstract tradeProcessor)
        {
            this.tradeProcessor = tradeProcessor;
        }

        public void ProcessTrades()
        {
            var lines = tradeProcessor.GetTradeData();
            var trades = tradeProcessor.Parse(lines);
            tradeProcessor.Persist(trades);
        }
    }
}
