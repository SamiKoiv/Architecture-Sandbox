using Microsoft.Extensions.Logging;

namespace RentalService.Main.Logging
{
    internal class ConsoleLogger : ILogger
    {
        public LogLevel Level { get; set; }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel) => logLevel >= Level;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}
