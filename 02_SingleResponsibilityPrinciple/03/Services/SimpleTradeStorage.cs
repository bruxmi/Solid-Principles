﻿using System.Collections.Generic;
using System.Linq;
using Solid._01_Start;
using Solid._02_SingleResponsibilityPrinciple._03.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple._03.Services
{
    public class SimpleTradeStorage : ITradeStorage
    {
        private readonly ILogger logger;

        public SimpleTradeStorage(ILogger logger)
        {
            this.logger = logger;
        }

        public void Persist(IEnumerable<TradeRecord> trades)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection("Data Source = (local); Initial Catalog = TradeDatabase; Integrated Security = True"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (var trade in trades)
                    {
                        var command = connection.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "dbo.insert_trade";
                        command.Parameters.AddWithValue("@sourceCurrency", trade.SourceCurrency);
                        command.Parameters.AddWithValue("@destinationCurrency",
                        trade.DestinationCurrency);
                        command.Parameters.AddWithValue("@lots", trade.Lots);
                        command.Parameters.AddWithValue("@price", trade.Price);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                connection.Close();
            }
            this.logger.LogWarning("INFO: {0} trades processed", trades.Count());
        }
    }
}