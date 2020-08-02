using System;
using System.Collections.Generic;

namespace MknSummit.Core.Models
{
    public class Agenda
    {
        public DateTime DayAndHour { get; set; }
        public List<Session> Sessions { get; set; }
    }
}
