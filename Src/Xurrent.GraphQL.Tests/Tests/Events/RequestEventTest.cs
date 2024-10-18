using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class RequestEventTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void CreateEvent()
        {
            RequestEventCreateInput requestCreate = new RequestEventCreateInput()
                .Category(RequestCategory.Incident)
                .Note("The first note")
                .Subject("Xurrent.GraphQL Test")
                .Source("Xurrent.GraphQL")
                .SourceID("1")
                .ServiceInstance(416)
                .Impact(RequestImpact.Medium)
                .ConfigurationItem(1998)
                .Team(12);
            Request request = client.CreateEvent(requestCreate).Result;
            Assert.IsNotNull(request);
            Assert.IsTrue(!string.IsNullOrEmpty(request.RequestId));
            Assert.IsTrue(request.GetIdentifier() > 0);

            requestCreate = new RequestEventCreateInput()
                .Category(RequestCategory.Incident)
                .Note("The second note")
                .Subject("Xurrent.GraphQL Test")
                .Source("Xurrent.GraphQL")
                .SourceID("1")
                .ServiceInstance(416)
                .Impact(RequestImpact.Medium)
                .ConfigurationItem(1998)
                .Team(12);
            Request secondRequest = client.CreateEvent(requestCreate).Result;
            Assert.IsNotNull(request);
            Assert.IsNotNull(request.RequestId);
            Assert.IsTrue(request.RequestId != string.Empty);
            Assert.IsTrue(request.GetIdentifier() > 0);

            Assert.IsTrue(request.RequestId.Equals(secondRequest.RequestId));
        }
    }
}
