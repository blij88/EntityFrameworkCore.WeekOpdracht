using EntityFrameworkCore.WeekOpdracht.Business.Entities;
using EntityFrameworkCore.WeekOpdracht.Business.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace EntityFrameworkCore.WeekOpdracht.Business
{
    public class FileLog : ILogging
    {

        public FileLog()
        {
        }
        public void Log(string Message, LogLevel Level, Exception e)
        {
            var log = new LogMessage(e, Message, Level);
            WriteToFile(log);
        }

        public void Log(string Message, LogLevel Level)
        {
            var log = new LogMessage(Message, Level);
            WriteToFile(log);
        }

        public void Log(string Message)
        {
            var log = new LogMessage(Message);
            WriteToFile(log);
        }


        private static void WriteToFile(LogMessage log)
        {
            using StreamWriter file = new("logFile.txt", append: true);
            file.WriteLine($"{log.Logged};{log.Level};{log.Message}");
        }
    }

}
