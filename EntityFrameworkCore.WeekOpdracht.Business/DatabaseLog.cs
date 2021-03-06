using EntityFrameworkCore.WeekOpdracht.Business.Entities;
using EntityFrameworkCore.WeekOpdracht.Business.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace EntityFrameworkCore.WeekOpdracht.Business
{
    public class DatabaseLog : ILogging
    {
        private readonly DataContext dataContext;

        public DatabaseLog(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void Log(string Message, LogLevel Level, Exception e)
        {
            var log = new LogMessage(e, Message, Level);
            dataContext.Add(log);
            dataContext.SaveChanges();
        }

        public void Log(string Message, LogLevel Level)
        {
            var log = new LogMessage(Message, Level);
            dataContext.Add(log);
            dataContext.SaveChanges();
        }

        public void Log(string Message)
        {
            var log = new LogMessage(Message);
            dataContext.Add(log);
            dataContext.SaveChanges();
        }
    }

}
