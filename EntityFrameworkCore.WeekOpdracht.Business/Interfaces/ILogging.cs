using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.WeekOpdracht.Business.Interfaces
{
    public interface ILogging
    {
        void Log(string Message, LogLevel Level, Exception e);
        void Log(string Message, LogLevel Level);
        void Log(string Message);
    }
}
