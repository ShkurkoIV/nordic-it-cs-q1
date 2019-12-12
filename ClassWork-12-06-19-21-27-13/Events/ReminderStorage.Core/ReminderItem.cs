using System;
using System.Collections.Generic;
using System.Text;

namespace ReminderStorage.Core
{
    public class ReminderItem
    {
        public Guid ID { get; set; }
        public DateTimeOffset date{ get; set; }
        public string Message{ get; set; }
        public string ContactID { get; set; }
        public TimeSpan TimeToSend => date - DateTime.UtcNow;


        public ReminderItem(Guid ID, DateTimeOffset date, string message, string ContactID) {
            this.ID = ID;
            this.date = date;
            this.Message = message;
            this.ContactID = ContactID;
        }
    }
}
