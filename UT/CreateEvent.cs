using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UT
{
    [TestClass]
    public class CreateEvent
    {

        [TestMethod]
        public void CE_1()
        {
            string title = "Test";
            DateTime startTime = Calendar.GetStartTime();

            Calendar calendar = Calendar.GetCaledars()[0];
            DateTime endTime = startTime.AddMinutes(calendar.DefaultDuration);
            
            Event calendarEvent = Calendar.CreateEvent(
                title,
                startTime,
                endTime,
                calendar
            );
            Assert.IsTrue(calendarEvent.Title == title);
            Assert.IsTrue(calendarEvent.StartTime == startTime);
            Assert.IsTrue(calendarEvent.EndTime == endTime);
            Assert.IsTrue(Calendar.GetCalendarByEvent(calendarEvent) == calendar);
        }
    }
}
