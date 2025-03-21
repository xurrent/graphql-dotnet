﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ProjectRiskLevelTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProjectRiskLevel> projectRiskLevels = client.Get(Query.ProjectRiskLevel
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(projectRiskLevels);
            Console.WriteLine($"Count: {projectRiskLevels.Count}");

            if (projectRiskLevels.Any())
            {
                projectRiskLevels = client.Get(new ProjectRiskLevelQuery(projectRiskLevels.First().ID)).Result;
                Assert.IsNotNull(projectRiskLevels);
            }
        }
    }
}
