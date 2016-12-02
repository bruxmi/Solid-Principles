namespace Solid.OpenClosedPrinciple.VirtualMethods
{
    public class TradeProcessorVersion2: TradeProcessor
    {
        public override void ProcessTrades()
        {
            base.ProcessTrades();
            this.DoSomeMoreStuff();
        }

        public void DoSomeMoreStuff()
        {
        }
    }
}
