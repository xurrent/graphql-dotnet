using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class ServiceLevelAgreementTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ServiceLevelAgreement> serviceLevelAgreements = client.Get(Query.ServiceLevelAgreement
                .View(ServiceLevelAgreementView.All)
                .SelectAll()
                .SelectCustomerRepresentatives(new PersonQuery()
                    .SelectAll())
                .SelectEffortClassRateIDs(new EffortClassRateIDQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectPeople(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ParentServiceInstanceQuery()
                    .SelectAll())
                .SelectSites(new SiteQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectCoverageGroups(new SlaCoverageGroupQuery()
                    .SelectAll())
                .SelectStandardServiceRequestActivityIDs(new StandardServiceRequestActivityIDQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(serviceLevelAgreements);
            Console.WriteLine($"Count: {serviceLevelAgreements.Count}");

            if (serviceLevelAgreements.Any())
            {
                serviceLevelAgreements = client.Get(new ServiceLevelAgreementQuery(serviceLevelAgreements.First().ID)).Result;
                Assert.IsNotNull(serviceLevelAgreements);
            }
        }
    }
}
