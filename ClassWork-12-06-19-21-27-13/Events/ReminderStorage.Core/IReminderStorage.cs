using System;
using System.Collections.Generic;
namespace ReminderStorage.Core
{
    public interface IReminderStorage
    {
        void Add(ReminderItem item);
        void Update(ReminderItem item);
        List<ReminderItem> GetList(IEnumerable<ReminderItemStatus> statuses, int count, int startposition);

    }
}
