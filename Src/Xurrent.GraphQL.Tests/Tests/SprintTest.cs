﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class SprintTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Sprint> sprints = client.Get(Query.Sprint
                .View(SprintView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll()
                    .SelectRecord())
                ).Result;

            Assert.IsNotNull(sprints);
            Console.WriteLine($"Count: {sprints.Count}");

            if (sprints.Any())
            {
                sprints = client.Get(new SprintQuery(sprints.First().ID)).Result;
                Assert.IsNotNull(sprints);
            }
        }
    }
}
