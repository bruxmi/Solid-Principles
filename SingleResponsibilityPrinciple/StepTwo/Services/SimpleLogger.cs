using Solid.SingleResponsibilityPrinciple.StepTwo.Interafaces;
using System;

namespace Solid.SingleResponsibilityPrinciple.StepTwo.Services
{
    public class SimpleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
