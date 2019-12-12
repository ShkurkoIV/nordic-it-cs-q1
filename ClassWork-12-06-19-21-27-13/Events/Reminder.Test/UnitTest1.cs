using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ReminderStorage.Core;


namespace Reminder.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Is_GUID_SET_CORRECT()
        {
            Guid guid = new Guid();
            ReminderItem reminder = new ReminderItem(
                guid, DateTimeOffset.MinValue, null, null);
            Assert.AreEqual(guid, reminder.ID);

        }


        [TestMethod]
        public void IsTimeToAlarm()
        {
            TimeSpan time = TimeSpan.FromMilliseconds(500);
            ReminderItem reminder = new ReminderItem(
                Guid.Empty, DateTime.UtcNow+time, null, null);
            Assert.IsTrue(time>reminder.TimeToSend);

        }
    }
}
