using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Reminder reminderItem1 = new Reminder(new DateTime(2020, 01, 01, 07, 0, 0), "Привет, сейчас 7 утра перого января.");
            Reminder reminderItem2 = new Reminder(DateTime.Today.AddDays(-1), "Привет, я будильник на вчера.");
            reminderItem1.WriteProperties();
            reminderItem2.WriteProperties();
            Console.ReadKey();
        }
    }
}
