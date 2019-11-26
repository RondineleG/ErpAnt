namespace ErpAnt.ApplicationCore.Interfaces.Logger
{
    public interface ILoggerManger
    {
         void LogInformation(string message);
         void LogWarning(string message);
         void LogDebug(string message);
         void LogError(string message);

    }
} 