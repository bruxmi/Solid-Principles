﻿using Solid._02_SingleResponsibilityPrinciple._03.Implementation;

namespace Solid._02_SingleResponsibilityPrinciple
{
    /// <summary>
    /// The class models the process of transferring trade data from one format to another. This is its only
    /// responsibility, its only concern, and the only reason that this class should change.
    /// </summary>
    public class TradeProcessor
    {
        private readonly StreamTradeDataProvider _tradeDataProvider;
        private readonly SimpleTradeParser _tradeParser;
        private readonly SimpleTradeStorage _tradeStorage;

        public TradeProcessor(StreamTradeDataProvider tradeDataProvider, SimpleTradeParser tradeParser, SimpleTradeStorage tradeStorage)
        {
            this._tradeDataProvider = tradeDataProvider;
            this._tradeParser = tradeParser;
            this._tradeStorage = tradeStorage;
        }

        public void ProcessTrades()
        {
            var lines = this._tradeDataProvider.GetTradeData();
            var trades = this._tradeParser.Parse(lines);
            this._tradeStorage.Persist(trades);
        }
    }
}
