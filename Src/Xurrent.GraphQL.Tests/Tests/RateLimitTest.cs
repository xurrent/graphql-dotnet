﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class RateLimitTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<RateLimit> rateLimits = client.Get(Query.RateLimit
                .View(DefaultView.None)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(rateLimits);
            Console.WriteLine($"Count: {rateLimits.Count}");
            Assert.IsTrue(rateLimits.Count == 1);
        }
    }
}
