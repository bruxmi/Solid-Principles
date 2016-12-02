using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.SingleResponsibilityPrinciple.StepTwo.Interfaces;

namespace Solid.SingleResponsibilityPrinciple.StepTwo
{
    public class TradeProcessor
    {
        private readonly ITradeDataProvider tradeDataProvider;
        private readonly ITradeParser tradeParser;
        private readonly ITradeStorage tradeStorage;

        public TradeProcessor(ITradeDataProvider tradeDataProvider, ITradeParser tradeParser, ITradeStorage tradeStorage)
        {
            this.tradeDataProvider = tradeDataProvider;
            this.tradeParser = tradeParser;
            this.tradeStorage = tradeStorage;
        }

        public void ProcessTrades()
        {
            var lines = tradeDataProvider.GetTradeData();
            var trades = tradeParser.Parse(lines);
            tradeStorage.Persist(trades);
        }
    }
}
