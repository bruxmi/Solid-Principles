using System.Collections.Generic;
using System.IO;
using Solid._02_SingleResponsibilityPrinciple._02.Interfaces;

namespace Solid._02_SingleResponsibilityPrinciple._02.Implementation
{
    public class StreamTradeDataProvider : ITradeDataProvider
    {
        public StreamTradeDataProvider(Stream stream)
        {
            this.stream = stream;
        }

        //Moving the input parameter to the constructor removes the dependency from the interface
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
