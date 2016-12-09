using System.Collections.Generic;
using System.IO;
using Solid._02_SingleResponsibilityPrinciple._03.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple._03.Services
{
    public class StreamTradeDataProvider : ITradeDataProvider
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
