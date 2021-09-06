using EntityFrameworkCore.WeekOpdracht.Business.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace EntityFrameworkCore.WeekOpdracht.Business
{
    public class ConsoleLog : ILogging
    {

        public void Log(string Message, LogLevel Level, Exception e)
        {
            Console.WriteLine($"{Level}: {e}, {Message}");
        }

        public void Log(string Message, LogLevel Level)
        {
            Console.WriteLine($"{Level}: {Message}");
        }

        public void Log(string Message)
        {
            Console.WriteLine($"logging: {Message}");
        }
    }
}
