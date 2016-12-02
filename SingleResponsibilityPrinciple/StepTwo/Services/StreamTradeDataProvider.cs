﻿using System.Collections.Generic;
using Solid.SingleResponsibilityPrinciple.StepTwo.Interfaces;
using System.IO;

namespace Solid.SingleResponsibilityPrinciple.StepTwo.Services
{
    public class StreamTradeDataProvider : ITradeDataProvider
    {
        public StreamTradeDataProvider(Stream stream)
        {
            this.stream = stream;
        }

        public IEnumerable<string> GetTradeData()
        {
            var tradeData = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            return tradeData;
        }
        private Stream stream;
    }
}
