﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ProjectCategoryTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProjectCategory> projectCategories = client.Get(Query.ProjectCategory
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(projectCategories);
            Console.WriteLine($"Count: {projectCategories.Count}");

            if (projectCategories.Any())
            {
                projectCategories = client.Get(new ProjectCategoryQuery(projectCategories.First().ID)).Result;
                Assert.IsNotNull(projectCategories);
            }
        }
    }
}
