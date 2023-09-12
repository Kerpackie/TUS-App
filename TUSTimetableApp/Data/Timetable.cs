using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSTimetableApp.Data
{
    public class Timetable
    {
        public string Group { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Subject { get; set; }
        public string Room { get; set; }
        public string LectureType { get; set; }

        public Timetable(string group, string day, string start, string end, string subject, string room, string type)
        {
            Group = group;
            DayOfWeek = day;
            StartTime = start;
            EndTime = end;
            Subject = subject;
            Room = room;
            LectureType = type;
        }

    }
}
