using System.Diagnostics;

namespace RouxAcademy.LoggerService
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Trace.WriteLine(message);
        }
    }
}