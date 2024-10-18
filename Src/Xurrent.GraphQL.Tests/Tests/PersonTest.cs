using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class PersonTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Person> people = client.Get(Query.Person
                .View(PersonView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCart(new ShopOrderLineQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectContacts(new ContactQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectOutOfOfficePeriods(new OutOfOfficePeriodQuery()
                    .SelectAll())
                .SelectPermissions(new PermissionQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectTeams(new TeamQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(people);
            Console.WriteLine($"Count: {people.Count}");

            if (people.Any())
            {
                Person? person = client.Get(new PersonQuery(people.First().ID).Select(PersonField.ID, PersonField.CreatedAt, PersonField.UpdatedAt)).Result.FirstOrDefault();
                Assert.IsNotNull(person);
                Assert.IsTrue(person.GetIdentifier() > 0);
                Assert.IsNotNull(person.CreatedAt);
                Assert.IsNotNull(person.UpdatedAt);
                Assert.IsNull(person.PrimaryEmail);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(XurrentException), "The id cannot be null or empty")]
        public void GetException()
        {
            DataList<Person> people = client.Get(new PersonQuery("")).Result;
            Assert.IsNotNull(people);
        }
    }
}
