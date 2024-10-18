using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class AccountTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            Account account = client.Account().Result;
            Assert.IsNotNull(account);
            Assert.ThrowsException<XurrentException>(() => account.GetIdentifier());
        }
    }
}
