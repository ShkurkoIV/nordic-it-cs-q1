using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Reminder : IReminderItem
    {
        DateTimeOffset alarmDate;
        TimeSpan timeToAlarm;
        bool isOutdated;
        public DateTimeOffset AlarmDate
        {
            get
            {
                return alarmDate;
            }
            set
            {
                alarmDate = value;
                timeToAlarm = DateTime.Now - alarmDate;
                isOutdated = timeToAlarm.TotalMilliseconds >= 0; 
            }
        }
        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm
        {
            get
            {
                return timeToAlarm;
            }
        }

        public bool IsOutdated
        {
            get
            {
                return isOutdated;
            }
        }

        public void WriteProperties()
        {
            Console.WriteLine($"{nameof(AlarmDate)} : {AlarmDate} \n" +
                              $"{nameof(AlarmMessage)} : {AlarmMessage} \n" +
                              $"{nameof(TimeToAlarm)} : {timeToAlarm} \n" +
                              $"{nameof(IsOutdated)} : {IsOutdated} \n");
        }

        public Reminder(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
    }
}
