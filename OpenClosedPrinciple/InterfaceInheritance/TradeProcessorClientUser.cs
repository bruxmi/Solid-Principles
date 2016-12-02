namespace Solid.OpenClosedPrinciple.InterfaceInheritance
{
    public class TradeProcessorClientUser
    {
        public void UseTradeProcessorClient()
        {
            var tradeProcessorClient1 = new TradeProcessorClient(new TradeProcessor());
            tradeProcessorClient1.ProcessTrades();

            var tradeProcessorClient2 = new TradeProcessorClient(new TradeProcessorAudit());
            tradeProcessorClient2.ProcessTrades();
        }
    }
}
