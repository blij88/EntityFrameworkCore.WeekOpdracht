using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.WeekOpdracht.Business.Entities
{
    public class LogMessage
    {
        public int Id { get; set; }
        public DateTime Logged { get; set; }
        public string Message { get; set; }
        [MaxLength(50)]
        public string Level {  get; set; }   
    }
}
