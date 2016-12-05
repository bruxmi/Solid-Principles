using System;
using Solid._02_SingleResponsibilityPrinciple._02.Interafaces;

namespace Solid._02_SingleResponsibilityPrinciple._02.Services
{
    public class SimpleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
