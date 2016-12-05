﻿using System.Collections.Generic;
using Solid._01_Start;
using Solid._02_SingleResponsibilityPrinciple._02.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple._02.Services
{
    public class SimpleTradeParser : ITradeParser
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
                var fields = line.Split(new char[] { ',' });
                if (!tradeValidator.Validate(fields))
                {
                    continue;
                }
                var trade = tradeMapper.Map(fields);
                trades.Add(trade);
                lineCount++;
            }
            return trades;
        }
    }
}