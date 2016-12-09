namespace Solid._03_OpenClosedPrinciple.AbstractMethods
{
    public class TradeProcessorClientUser
    {
        public void UseTradeProcessorClient()
        {
            var tradeProcessorClient1 = new TradeProcessorClient(new TradeProcessor());
            tradeProcessorClient1.ProcessTrades();

            var tradeProcessorClient2 = new TradeProcessorClient(new TradeProcessorVersion2());
            tradeProcessorClient2.ProcessTrades();
        }
    }
}
