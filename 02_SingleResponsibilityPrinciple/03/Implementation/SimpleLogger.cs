using System;

namespace Solid._02_SingleResponsibilityPrinciple._03.Implementation
{
    public class SimpleLogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
