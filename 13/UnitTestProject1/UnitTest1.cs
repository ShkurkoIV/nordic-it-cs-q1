using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using ReminderStorage.InMemory;
using System;
using System.Collections.Generic;


namespace Reminder.Storage.InMemory.Tests
{
    [TestClass]
    public class InMemoryStorageTests
    {
        private InMemoryStorage storage;
        private Guid[] guids;
        private DateTime time;
        private long[] ids;
        private ReminderItem[] reminders;

        [TestInitialize]
        public void TestInitialize()
        {
            storage = new InMemoryStorage();
            guids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
            ids = new long[] { 1, 2, 3 };
            time = DateTime.Now;
            ReminderItem reminderItem1 = new ReminderItem(guids[0], time, "", ids[0]);
            ReminderItem reminderItem2 = new ReminderItem(guids[1], time, "", ids[1]);
            reminders = new ReminderItem[] { reminderItem1, reminderItem2 };
            storage.Add(guids[0], reminderItem1);
            storage.Add(guids[1], reminderItem2);
        }

        [TestMethod]
        public void GetListTest()
        {

            List<ReminderItem> result = new List<ReminderItem>();
            result.Add(reminders[0]);
            result.Add(reminders[1]);
            var expect = storage.GetList();
            CollectionAssert.AreEquivalent(expect, result); 

        }
    }
}
