using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ShopOrderLineTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ShopOrderLine> shopOrderLines = client.Get(Query.ShopOrderLine
                .View(ShopOrderLineView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(shopOrderLines);
            Console.WriteLine($"Count: {shopOrderLines.Count}");

            if (shopOrderLines.Any())
            {
                shopOrderLines = client.Get(new ShopOrderLineQuery(shopOrderLines.First().ID)).Result;
                Assert.IsNotNull(shopOrderLines);
            }
        }
    }
}
