namespace Solid._03_OpenClosedPrinciple.VirtualMethods
{
    public class TradeProcessorVersion2: TradeProcessor
    {
        public override void ProcessTrades()
        {
            this.DoSomeMoreStuff();
            base.ProcessTrades();
        }

        public void DoSomeMoreStuff()
        {
        }
    }
}
