using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.WeekOpdracht.Business.Entities
{
    public class LogMessage
    {
        public LogMessage(Exception exception, string message, LogLevel level)
        {
            Exception = exception;
            Message = message;
            Level = Level;
            Logged = DateTime.Now;
     
        }
        public LogMessage(string message, LogLevel level)
        {
            Message = message;
            Level = Level;
            Logged = DateTime.Now;
        }
        public LogMessage(string message)
        {
            Message = message;
            Logged = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime Logged { get; set; }
        public string Message { get; set; }
        [MaxLength(50)]
        public LogLevel Level { get; set; }

        [NotMapped]
        public Exception Exception { get; set; }
    }
}
