namespace Solid._03_OpenClosedPrinciple.VirtualMethods
{
    public class TradeProcessorClientUser
    {
        public void UseTradeProcessorClient()
        {
            var tradeProcessorClient = new TradeProcessorClient();
            tradeProcessorClient.ProcessTrades(new TradeProcessor());
            //Polymorphism
            tradeProcessorClient.ProcessTrades(new TradeProcessorVersion2());
        }
    }
}
