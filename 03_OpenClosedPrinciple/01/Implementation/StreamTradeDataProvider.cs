using Solid._03_OpenClosedPrinciple._01.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Solid._03_OpenClosedPrinciple._01.Implementation
{
    public class StreamTradeDataProvider: ITradeDataProvider
    {
        //Only the constructor 
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
