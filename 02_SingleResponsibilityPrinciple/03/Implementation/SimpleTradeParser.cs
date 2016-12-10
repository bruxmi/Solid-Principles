using System.Collections.Generic;
using Solid._01_Start;

namespace Solid._02_SingleResponsibilityPrinciple._03.Implementation
{
    public class SimpleTradeParser
    {

        private readonly SimpleTradeValidator tradeValidator;
        private readonly SimpleTradeMapper tradeMapper;

        public SimpleTradeParser(SimpleTradeValidator tradeValidator, SimpleTradeMapper tradeMapper)
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