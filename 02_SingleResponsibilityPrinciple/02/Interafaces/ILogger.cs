namespace Solid._02_SingleResponsibilityPrinciple._02.Interafaces
{
    public interface ILogger
    {
        void LogWarning(string message, params object[] args);
    }
}
