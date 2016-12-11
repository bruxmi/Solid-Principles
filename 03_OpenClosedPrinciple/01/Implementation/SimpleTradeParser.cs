using System.Collections.Generic;
using Solid._01_Start;
using Solid._03_OpenClosedPrinciple._01.Interfaces;

namespace Solid._03_OpenClosedPrinciple._01.Implementation
{
    public class SimpleTradeParser: ITradeParser
    {

        private readonly ITradeValidator tradeValidator;
        private readonly ITradeMapper tradeMapper;

        public SimpleTradeParser(ITradeValidator tradeValidator, ITradeMapper tradeMapper)
        {
            this.tradeValidator = tradeValidator;
            this.tradeMapper = tradeMapper;
        }

        public IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData)
        {
            var trades = new List<TradeRecord>();
            var lineCount = 1;
            foreach (var line in tradeData)
            {
                var fields = line.Split(',');
                if (!this.tradeValidator.Validate(fields))
                {
                    continue;
                }
                var trade = this.tradeMapper.Map(fields);
                trades.Add(trade);
                lineCount++;
            }
            return trades;
        }
    }
}