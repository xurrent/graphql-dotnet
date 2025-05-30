﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class WaitingForCustomerFollowUpTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<WaitingForCustomerFollowUp> customCollections = client.Get(Query.WaitingForCustomerFollowUp
                .View(DefaultView.None)
                .SelectAll()
                .SelectWaitingForCustomerRules(new WaitingForCustomerRuleQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(customCollections);
            Console.WriteLine($"Count: {customCollections.Count}");

            if (customCollections.Any())
            {
                customCollections = client.Get(new WaitingForCustomerFollowUpQuery(customCollections.First().ID)).Result;
                Assert.IsNotNull(customCollections);
            }
        }
    }
}
