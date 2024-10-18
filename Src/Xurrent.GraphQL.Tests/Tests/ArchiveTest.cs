using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ArchiveTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Archive> archives = client.Get(Query.Archive
                .View(ArchiveView.All)
                .SelectAll()
                .SelectArchived(personQuery: new PersonQuery().Select(PersonField.ID, PersonField.PrimaryEmail, PersonField.Name))
                ).Result;

            Assert.IsNotNull(archives);
            Console.WriteLine($"Count: {archives.Count}");

            if (archives.Any())
            {
                archives = client.Get(new ArchiveQuery(archives.First().ID)).Result;
                Assert.IsNotNull(archives);
            }
        }
    }
}
