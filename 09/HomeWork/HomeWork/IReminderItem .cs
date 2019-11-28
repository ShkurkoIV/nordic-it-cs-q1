using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    interface IReminderItem
    {
        DateTimeOffset AlarmDate { get; set; }
        string AlarmMessage { get; set; }
        TimeSpan TimeToAlarm { get; }
        bool IsOutdated { get; }
        void WriteProperties();
    }
}
