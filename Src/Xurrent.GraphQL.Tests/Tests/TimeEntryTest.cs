﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class TimeEntryTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<TimeEntry> timeEntries = client.Get(Query.TimeEntry
                .View(TimeEntryView.All)
                .SelectAll()
                .SelectAssignment(new RequestQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(timeEntries);
            Console.WriteLine($"Count: {timeEntries.Count}");

            if (timeEntries.Any())
            {
                timeEntries = client.Get(new TimeEntryQuery(timeEntries.First().ID)).Result;
                Assert.IsNotNull(timeEntries);
            }
        }
    }
}
