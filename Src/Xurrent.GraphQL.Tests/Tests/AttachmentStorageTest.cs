using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class AttachmentStorageTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<AttachmentStorage> attachmentStorages = client.Get(Query.AttachmentStorage
                .View(DefaultView.None)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(attachmentStorages);
            Assert.IsTrue(attachmentStorages.Count == 1);
        }
    }
}
