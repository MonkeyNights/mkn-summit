using System;
using System.Collections.Generic;

namespace MknSummit.Core.Models
{
    public class Schedule
    {
        public DateTime DayAndHour { get; set; }
        public List<Session> Sessions { get; set; }

        public Schedule()
        {
            Sessions = new List<Session>();
        }
    }
}
