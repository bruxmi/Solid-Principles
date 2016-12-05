namespace Solid._03_OpenClosedPrinciple.InterfaceInheritance
{
    public class TradeProcessorClient
    {
        private readonly ITradeProcessor tradeProcessor;

        public TradeProcessorClient(ITradeProcessor tradeProcessor)
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
