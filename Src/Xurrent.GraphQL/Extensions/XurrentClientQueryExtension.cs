using System.Threading.Tasks;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// All GraphQL query operations.
    /// </summary>
    public static class XurrentClientQueryExtension
    {
        /// <summary>
        /// The current account.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Account>> Get(this XurrentClient client, AccountQuery query)
        {
            return await client.Get<Account>(query);
        }

        /// <summary>
        /// Root connection for retrieving AffectedSla records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<AffectedSla>> Get(this XurrentClient client, AffectedSlaQuery query)
        {
            return await client.Get<AffectedSla>(query);
        }

        /// <summary>
        /// Root connection for retrieving AgileBoard records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<AgileBoard>> Get(this XurrentClient client, AgileBoardQuery query)
        {
            return await client.Get<AgileBoard>(query);
        }

        /// <summary>
        /// Root connection for retrieving AppInstance records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<AppInstance>> Get(this XurrentClient client, AppInstanceQuery query)
        {
            return await client.Get<AppInstance>(query);
        }

        /// <summary>
        /// Root connection for retrieving AppOffering records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<AppOffering>> Get(this XurrentClient client, AppOfferingQuery query)
        {
            return await client.Get<AppOffering>(query);
        }

        /// <summary>
        /// Root connection for retrieving Archive records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Archive>> Get(this XurrentClient client, ArchiveQuery query)
        {
            return await client.Get<Archive>(query);
        }

        /// <summary>
        /// Details on how to upload files to the Xurrent attachment storage facility.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<AttachmentStorage>> Get(this XurrentClient client, AttachmentStorageQuery query)
        {
            return await client.Get<AttachmentStorage>(query);
        }

        /// <summary>
        /// Root connection for retrieving AutomationRule records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<AutomationRule>> Get(this XurrentClient client, AutomationRuleQuery query)
        {
            return await client.Get<AutomationRule>(query);
        }

        /// <summary>
        /// Root connection for retrieving Broadcast records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Broadcast>> Get(this XurrentClient client, BroadcastQuery query)
        {
            return await client.Get<Broadcast>(query);
        }

        /// <summary>
        /// Root connection for retrieving Calendar records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Calendar>> Get(this XurrentClient client, CalendarQuery query)
        {
            return await client.Get<Calendar>(query);
        }

        /// <summary>
        /// Root connection for retrieving ConfigurationItem records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ConfigurationItem>> Get(this XurrentClient client, ConfigurationItemQuery query)
        {
            return await client.Get<ConfigurationItem>(query);
        }

        /// <summary>
        /// Root connection for retrieving Contract records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Contract>> Get(this XurrentClient client, ContractQuery query)
        {
            return await client.Get<Contract>(query);
        }

        /// <summary>
        /// Root connection for retrieving CustomCollectionElement records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<CustomCollectionElement>> Get(this XurrentClient client, CustomCollectionElementQuery query)
        {
            return await client.Get<CustomCollectionElement>(query);
        }

        /// <summary>
        /// Root connection for retrieving CustomCollection records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<CustomCollection>> Get(this XurrentClient client, CustomCollectionQuery query)
        {
            return await client.Get<CustomCollection>(query);
        }

        /// <summary>
        /// Root connection for retrieving EffortClass records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<EffortClass>> Get(this XurrentClient client, EffortClassQuery query)
        {
            return await client.Get<EffortClass>(query);
        }

        /// <summary>
        /// Root connection for retrieving FirstLineSupportAgreement records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<FirstLineSupportAgreement>> Get(this XurrentClient client, FirstLineSupportAgreementQuery query)
        {
            return await client.Get<FirstLineSupportAgreement>(query);
        }

        /// <summary>
        /// Root connection for retrieving Holiday records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Holiday>> Get(this XurrentClient client, HolidayQuery query)
        {
            return await client.Get<Holiday>(query);
        }

        /// <summary>
        /// Root connection for retrieving Invoice records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Invoice>> Get(this XurrentClient client, InvoiceQuery query)
        {
            return await client.Get<Invoice>(query);
        }

        /// <summary>
        /// Root connection for retrieving KnowledgeArticle records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<KnowledgeArticle>> Get(this XurrentClient client, KnowledgeArticleQuery query)
        {
            return await client.Get<KnowledgeArticle>(query);
        }

        /// <summary>
        /// Root connection for retrieving KnowledgeArticleTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<KnowledgeArticleTemplate>> Get(this XurrentClient client, KnowledgeArticleTemplateQuery query)
        {
            return await client.Get<KnowledgeArticleTemplate>(query);
        }

        /// <summary>
        /// The currently authenticated person.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Person>> Get(this XurrentClient client, MeQuery query)
        {
            return await client.Get<Person>(query);
        }

        /// <summary>
        /// Root connection for retrieving Organization records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Organization>> Get(this XurrentClient client, OrganizationQuery query)
        {
            return await client.Get<Organization>(query);
        }

        /// <summary>
        /// Root connection for retrieving OutOfOfficePeriod records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<OutOfOfficePeriod>> Get(this XurrentClient client, OutOfOfficePeriodQuery query)
        {
            return await client.Get<OutOfOfficePeriod>(query);
        }

        /// <summary>
        /// Root connection for retrieving PdfDesign records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<PdfDesign>> Get(this XurrentClient client, PdfDesignQuery query)
        {
            return await client.Get<PdfDesign>(query);
        }

        /// <summary>
        /// Root connection for retrieving Person records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Person>> Get(this XurrentClient client, PersonQuery query)
        {
            return await client.Get<Person>(query);
        }

        /// <summary>
        /// Root connection for retrieving Problem records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Problem>> Get(this XurrentClient client, ProblemQuery query)
        {
            return await client.Get<Problem>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProductBacklog records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProductBacklog>> Get(this XurrentClient client, ProductBacklogQuery query)
        {
            return await client.Get<ProductBacklog>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProductCategory records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProductCategory>> Get(this XurrentClient client, ProductCategoryQuery query)
        {
            return await client.Get<ProductCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving Product records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Product>> Get(this XurrentClient client, ProductQuery query)
        {
            return await client.Get<Product>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectCategory records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProjectCategory>> Get(this XurrentClient client, ProjectCategoryQuery query)
        {
            return await client.Get<ProjectCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectRiskLevel records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProjectRiskLevel>> Get(this XurrentClient client, ProjectRiskLevelQuery query)
        {
            return await client.Get<ProjectRiskLevel>(query);
        }

        /// <summary>
        /// Root connection for retrieving Project records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Project>> Get(this XurrentClient client, ProjectQuery query)
        {
            return await client.Get<Project>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectTask records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProjectTask>> Get(this XurrentClient client, ProjectTaskQuery query)
        {
            return await client.Get<ProjectTask>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectTaskTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProjectTaskTemplate>> Get(this XurrentClient client, ProjectTaskTemplateQuery query)
        {
            return await client.Get<ProjectTaskTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ProjectTemplate>> Get(this XurrentClient client, ProjectTemplateQuery query)
        {
            return await client.Get<ProjectTemplate>(query);
        }

        /// <summary>
        /// The rate limit status.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<RateLimit>> Get(this XurrentClient client, RateLimitQuery query)
        {
            return await client.Get<RateLimit>(query);
        }

        /// <summary>
        /// Root connection for retrieving Release records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Release>> Get(this XurrentClient client, ReleaseQuery query)
        {
            return await client.Get<Release>(query);
        }

        /// <summary>
        /// Root connection for retrieving Request records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Request>> Get(this XurrentClient client, RequestQuery query)
        {
            return await client.Get<Request>(query);
        }

        /// <summary>
        /// Root connection for retrieving RequestTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<RequestTemplate>> Get(this XurrentClient client, RequestTemplateQuery query)
        {
            return await client.Get<RequestTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving ReservationOffering records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ReservationOffering>> Get(this XurrentClient client, ReservationOfferingQuery query)
        {
            return await client.Get<ReservationOffering>(query);
        }

        /// <summary>
        /// Root connection for retrieving Reservation records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Reservation>> Get(this XurrentClient client, ReservationQuery query)
        {
            return await client.Get<Reservation>(query);
        }

        /// <summary>
        /// Root connection for retrieving Risk records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Risk>> Get(this XurrentClient client, RiskQuery query)
        {
            return await client.Get<Risk>(query);
        }

        /// <summary>
        /// Root connection for retrieving RiskSeverity records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<RiskSeverity>> Get(this XurrentClient client, RiskSeverityQuery query)
        {
            return await client.Get<RiskSeverity>(query);
        }

        /// <summary>
        /// Root connection for retrieving ScrumWorkspace records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ScrumWorkspace>> Get(this XurrentClient client, ScrumWorkspaceQuery query)
        {
            return await client.Get<ScrumWorkspace>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceCategory records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ServiceCategory>> Get(this XurrentClient client, ServiceCategoryQuery query)
        {
            return await client.Get<ServiceCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceInstance records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ServiceInstance>> Get(this XurrentClient client, ServiceInstanceQuery query)
        {
            return await client.Get<ServiceInstance>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceLevelAgreement records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ServiceLevelAgreement>> Get(this XurrentClient client, ServiceLevelAgreementQuery query)
        {
            return await client.Get<ServiceLevelAgreement>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceOffering records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ServiceOffering>> Get(this XurrentClient client, ServiceOfferingQuery query)
        {
            return await client.Get<ServiceOffering>(query);
        }

        /// <summary>
        /// Root connection for retrieving Service records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Service>> Get(this XurrentClient client, ServiceQuery query)
        {
            return await client.Get<Service>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShopArticleCategory records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ShopArticleCategory>> Get(this XurrentClient client, ShopArticleCategoryQuery query)
        {
            return await client.Get<ShopArticleCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShopArticle records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ShopArticle>> Get(this XurrentClient client, ShopArticleQuery query)
        {
            return await client.Get<ShopArticle>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShopOrderLine records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ShopOrderLine>> Get(this XurrentClient client, ShopOrderLineQuery query)
        {
            return await client.Get<ShopOrderLine>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShortUrl records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<ShortUrl>> Get(this XurrentClient client, ShortUrlQuery query)
        {
            return await client.Get<ShortUrl>(query);
        }

        /// <summary>
        /// Root connection for retrieving Site records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Site>> Get(this XurrentClient client, SiteQuery query)
        {
            return await client.Get<Site>(query);
        }

        /// <summary>
        /// Root connection for retrieving SkillPool records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<SkillPool>> Get(this XurrentClient client, SkillPoolQuery query)
        {
            return await client.Get<SkillPool>(query);
        }

        /// <summary>
        /// Root connection for retrieving SlaNotificationScheme records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<SlaNotificationScheme>> Get(this XurrentClient client, SlaNotificationSchemeQuery query)
        {
            return await client.Get<SlaNotificationScheme>(query);
        }

        /// <summary>
        /// Root connection for retrieving Sprint records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Sprint>> Get(this XurrentClient client, SprintQuery query)
        {
            return await client.Get<Sprint>(query);
        }

        /// <summary>
        /// Root connection for retrieving SurveyResponse records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<SurveyResponse>> Get(this XurrentClient client, SurveyResponseQuery query)
        {
            return await client.Get<SurveyResponse>(query);
        }

        /// <summary>
        /// Root connection for retrieving Survey records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Survey>> Get(this XurrentClient client, SurveyQuery query)
        {
            return await client.Get<Survey>(query);
        }

        /// <summary>
        /// Root connection for retrieving SyncSet records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<SyncSet>> Get(this XurrentClient client, SyncSetQuery query)
        {
            return await client.Get<SyncSet>(query);
        }

        /// <summary>
        /// Root connection for retrieving Task records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Task>> Get(this XurrentClient client, TaskQuery query)
        {
            return await client.Get<Task>(query);
        }

        /// <summary>
        /// Root connection for retrieving TaskTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<TaskTemplate>> Get(this XurrentClient client, TaskTemplateQuery query)
        {
            return await client.Get<TaskTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving Team records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Team>> Get(this XurrentClient client, TeamQuery query)
        {
            return await client.Get<Team>(query);
        }

        /// <summary>
        /// Root connection for retrieving TimeAllocation records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<TimeAllocation>> Get(this XurrentClient client, TimeAllocationQuery query)
        {
            return await client.Get<TimeAllocation>(query);
        }

        /// <summary>
        /// Root connection for retrieving TimeEntry records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<TimeEntry>> Get(this XurrentClient client, TimeEntryQuery query)
        {
            return await client.Get<TimeEntry>(query);
        }

        /// <summary>
        /// Root connection for retrieving TimesheetSetting records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<TimesheetSetting>> Get(this XurrentClient client, TimesheetSettingQuery query)
        {
            return await client.Get<TimesheetSetting>(query);
        }

        /// <summary>
        /// Root connection for retrieving Translation records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Translation>> Get(this XurrentClient client, TranslationQuery query)
        {
            return await client.Get<Translation>(query);
        }

        /// <summary>
        /// Root connection for retrieving Trash records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Trash>> Get(this XurrentClient client, TrashQuery query)
        {
            return await client.Get<Trash>(query);
        }

        /// <summary>
        /// Root connection for retrieving UiExtension records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<UiExtension>> Get(this XurrentClient client, UiExtensionQuery query)
        {
            return await client.Get<UiExtension>(query);
        }

        /// <summary>
        /// Root connection for retrieving WaitingForCustomerFollowUp records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<WaitingForCustomerFollowUp>> Get(this XurrentClient client, WaitingForCustomerFollowUpQuery query)
        {
            return await client.Get<WaitingForCustomerFollowUp>(query);
        }

        /// <summary>
        /// Root connection for retrieving WebhookPolicy records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<WebhookPolicy>> Get(this XurrentClient client, WebhookPolicyQuery query)
        {
            return await client.Get<WebhookPolicy>(query);
        }

        /// <summary>
        /// Root connection for retrieving Webhook records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Webhook>> Get(this XurrentClient client, WebhookQuery query)
        {
            return await client.Get<Webhook>(query);
        }

        /// <summary>
        /// Root connection for retrieving Workflow records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<Workflow>> Get(this XurrentClient client, WorkflowQuery query)
        {
            return await client.Get<Workflow>(query);
        }

        /// <summary>
        /// Root connection for retrieving WorkflowTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<WorkflowTemplate>> Get(this XurrentClient client, WorkflowTemplateQuery query)
        {
            return await client.Get<WorkflowTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving WorkflowType records.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DataList<WorkflowType>> Get(this XurrentClient client, WorkflowTypeQuery query)
        {
            return await client.Get<WorkflowType>(query);
        }
    }
}
