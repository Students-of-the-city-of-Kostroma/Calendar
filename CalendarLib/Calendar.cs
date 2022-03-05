using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class Calendar
    {
        public int DefaultDuration { get; set; }

        public static object GetCalendarByEvent(Event calendarEvent)
        {
            throw new NotImplementedException();
        }

        public static Event CreateEvent(string title, DateTime startTime, DateTime endTime, Calendar calendar)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetStartTime()
        {
            throw new NotImplementedException();
        }

        public static Calendar[] GetCaledars()
        {
            throw new NotImplementedException();
        }
    }
}
