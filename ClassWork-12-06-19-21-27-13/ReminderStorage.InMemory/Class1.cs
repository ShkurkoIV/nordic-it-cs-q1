using System;
using System.Collections.Generic;
using ReminderStorage.Core;

namespace ReminderStorage.InMemory
{
    public class ReminderStorageInMemory : IReminderStorage
    {

        public void Add(ReminderItem item)
        {
            throw new NotImplementedException();
        }

        public List<ReminderItem> GetList(IEnumerable<ReminderItemStatus> statuses, int count, int startposition)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
