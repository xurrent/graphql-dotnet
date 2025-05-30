﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class SlaNotificationSchemeTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<SlaNotificationScheme> slaNotificationSchemes = client.Get(Query.SlaNotificationScheme
                .View(DefaultView.None)
                .SelectAll()
                .SelectSlaNotificationRules(new SlaNotificationRuleQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(slaNotificationSchemes);
            Console.WriteLine($"Count: {slaNotificationSchemes.Count}");

            if (slaNotificationSchemes.Any())
            {
                slaNotificationSchemes = client.Get(new SlaNotificationSchemeQuery(slaNotificationSchemes.First().ID)).Result;
                Assert.IsNotNull(slaNotificationSchemes);
            }
        }
    }
}
