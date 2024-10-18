using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ProductBacklogTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProductBacklog> productBacklogs = client.Get(Query.ProductBacklog
                .View(ProductBacklogView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectItems(new ProductBacklogItemQuery()
                    .SelectAll())
                .SelectScrumWorkspaces(new ScrumWorkspaceQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(productBacklogs);
            Console.WriteLine($"Count: {productBacklogs.Count}");

            if (productBacklogs.Any())
            {
                productBacklogs = client.Get(new ProductBacklogQuery(productBacklogs.First().ID)).Result;
                Assert.IsNotNull(productBacklogs);
            }
        }
    }
}
