﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ShortUrlTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ShortUrl> shortUrls = client.Get(Query.ShortUrl
                .View(ShortUrlView.All)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(shortUrls);
            Console.WriteLine($"Count: {shortUrls.Count}");

            if (shortUrls.Any())
            {
                shortUrls = client.Get(new ShortUrlQuery(shortUrls.First().ID)).Result;
                Assert.IsNotNull(shortUrls);
            }
        }
    }
}
