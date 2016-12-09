using System;
using System.Collections.Generic;
using Solid._01_Start;
using Solid._02_SingleResponsibilityPrinciple._02.Interfaces;

namespace Solid._02_SingleResponsibilityPrinciple._02.Implementation
{
    public class SimpleTradeParser : ITradeParser
    {
        public IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData)
        {
            var trades = new List<TradeRecord>();
            var lineCount = 1;
            foreach (var line in tradeData)
            {
                var fields = line.Split(',');
                if (!this.Validate(fields))
                {
                    continue;
                }
                var trade = this.Map(fields);
                trades.Add(trade);
                lineCount++;
            }
            return trades;
        }

        //violates single responsibility
        private bool Validate(string[] tradeData)
        {
            if (tradeData.Length != 3)
            {
                this.LogWarning("Line malformed. Only {1} field(s) found.", tradeData.Length);
                return false;
            }

            if (tradeData[0].Length != 6)
            {
                this.LogWarning("Trade currencies malformed: '{1}'", tradeData[0]);
                return false;
            }

            int tradeAmount;
            if (!int.TryParse(tradeData[1], out tradeAmount))
            {
                this.LogWarning("Trade amount not a valid integer: '{1}'", tradeData[1]);
                return false;
            }

            decimal tradePrice;
            if (!decimal.TryParse(tradeData[2], out tradePrice))
            {
                this.LogWarning("WARN: Trade price not a valid decimal: '{1}'", tradeData[2]);
                return false;
            }
            return true;
        }

        //violates single responsibility
        private void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }

        private static float LotSize = 100000f;
        //violates single responsibility
        private TradeRecord Map(string[] fields)
        {
            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);
            var tradeAmount = int.Parse(fields[1]);
            var tradePrice = decimal.Parse(fields[2]);
            var tradeRecord = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount/LotSize,
                Price = tradePrice
            };
            return tradeRecord;
        }
    }
}