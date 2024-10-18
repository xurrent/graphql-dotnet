using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ShopArticleCategoryTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ShopArticleCategory> shopArticleCategories = client.Get(Query.ShopArticleCategory
                .View(ShopArticleCategoryView.All)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(shopArticleCategories);
            Console.WriteLine($"Count: {shopArticleCategories.Count}");

            if (shopArticleCategories.Any())
            {
                shopArticleCategories = client.Get(new ShopArticleCategoryQuery(shopArticleCategories.First().ID)).Result;
                Assert.IsNotNull(shopArticleCategories);
            }
        }
    }
}
