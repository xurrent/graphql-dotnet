using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class TeamTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Team> teams = client.Get(Query.Team
                .View(TeamView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectMembers(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(teams);
            Console.WriteLine($"Count: {teams.Count}");

            if (teams.Any())
            {
                teams = client.Get(new TeamQuery(teams.First().ID)).Result;
                Assert.IsNotNull(teams);
            }
        }
    }
}
