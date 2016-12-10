using Solid._03_OpenClosedPrinciple._01.Interfaces;
using System;

namespace Solid._03_OpenClosedPrinciple._01.Implementation
{
    public class SimpleLogger: ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
