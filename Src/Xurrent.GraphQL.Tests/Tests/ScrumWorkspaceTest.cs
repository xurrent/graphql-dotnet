using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ScrumWorkspaceTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ScrumWorkspace> scrumWorkspaces = client.Get(Query.ScrumWorkspace
                .View(ScrumWorkspaceView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSprints(new SprintQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(scrumWorkspaces);
            Console.WriteLine($"Count: {scrumWorkspaces.Count}");

            if (scrumWorkspaces.Any())
            {
                scrumWorkspaces = client.Get(new ScrumWorkspaceQuery(scrumWorkspaces.First().ID)).Result;
                Assert.IsNotNull(scrumWorkspaces);
            }
        }
    }
}
