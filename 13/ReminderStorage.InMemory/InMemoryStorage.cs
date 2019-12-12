using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReminderStorage.InMemory
{
    public class InMemoryStorage : IReminderStorage
    {
        internal readonly Dictionary<Guid, ReminderItem> reminders = new Dictionary<Guid, ReminderItem>();
        
        public void Add(Guid guid, ReminderItem item)
        {
            reminders.Add(guid, item);
        }

        public ReminderItem Get(Guid id)
        {
            if (reminders[id] == null) throw new Exception("НЕ элемента с таким ID");
            return reminders[id];
        }

        public void Display()
        {

            if (reminders.Count > 0) { 
                string msg = "";

                foreach (KeyValuePair<Guid, ReminderItem> pair in reminders)
                    msg += $"{pair.Key.ToString()}. Отправить \"{pair.Value.Message}\" через {pair.Value._timeToAlarm.TotalSeconds}\n";
                Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine("Нет задач для выполнения");
            }

        }

        public List<ReminderItem> GetList()
        {
            return reminders.Select(kv => kv.Value).ToList();
        }
    }
}
