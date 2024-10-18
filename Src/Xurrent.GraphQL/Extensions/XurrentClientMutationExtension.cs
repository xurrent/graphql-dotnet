using System;
using System.Threading.Tasks;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// All GraphQL mutation operations.
    /// </summary>
    public static class XurrentClientMutationExtension
    {
        /// <summary>
        /// Creates a new agile board.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The agile board response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AgileBoardCreatePayload> Mutation(this XurrentClient client, AgileBoardCreateInput input, AgileBoardQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AgileBoardCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing agile board.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The agile board response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AgileBoardUpdatePayload> Mutation(this XurrentClient client, AgileBoardUpdateInput input, AgileBoardQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AgileBoardUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new app instance.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppInstanceCreatePayload> Mutation(this XurrentClient client, AppInstanceCreateInput input, AppInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppInstanceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing app instance.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppInstanceUpdatePayload> Mutation(this XurrentClient client, AppInstanceUpdateInput input, AppInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppInstanceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppOfferingAutomationRuleCreatePayload> Mutation(this XurrentClient client, AppOfferingAutomationRuleCreateInput input, AppOfferingAutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes an existing app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppOfferingAutomationRuleDeleteMutationPayload> Mutation(this XurrentClient client, AppOfferingAutomationRuleDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppOfferingAutomationRuleUpdatePayload> Mutation(this XurrentClient client, AppOfferingAutomationRuleUpdateInput input, AppOfferingAutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new app offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppOfferingCreatePayload> Mutation(this XurrentClient client, AppOfferingCreateInput input, AppOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new, published, app offering based on the current state of a draft app offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppOfferingPublishMutationPayload> Mutation(this XurrentClient client, AppOfferingPublishMutationInput input, AppOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingPublishMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing app offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AppOfferingUpdatePayload> Mutation(this XurrentClient client, AppOfferingUpdateInput input, AppOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new automation rule.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AutomationRuleCreatePayload> Mutation(this XurrentClient client, AutomationRuleCreateInput input, AutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AutomationRuleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<AutomationRuleUpdatePayload> Mutation(this XurrentClient client, AutomationRuleUpdateInput input, AutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AutomationRuleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new broadcast.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The broadcast response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<BroadcastCreatePayload> Mutation(this XurrentClient client, BroadcastCreateInput input, BroadcastQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new BroadcastCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing broadcast.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The broadcast response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<BroadcastUpdatePayload> Mutation(this XurrentClient client, BroadcastUpdateInput input, BroadcastQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new BroadcastUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new calendar.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The calendar response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<CalendarCreatePayload> Mutation(this XurrentClient client, CalendarCreateInput input, CalendarQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CalendarCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing calendar.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The calendar response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<CalendarUpdatePayload> Mutation(this XurrentClient client, CalendarUpdateInput input, CalendarQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CalendarUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new configuration item. **Important**: To facilitate integrations with discovery tools, the create is treated as an update in case the provided <c>name</c> or <c>label</c> is already used by an inactive CI in the same account.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The configuration item response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ConfigurationItemCreatePayload> Mutation(this XurrentClient client, ConfigurationItemCreateInput input, ConfigurationItemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ConfigurationItemCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing configuration item.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The configuration item response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ConfigurationItemUpdatePayload> Mutation(this XurrentClient client, ConfigurationItemUpdateInput input, ConfigurationItemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ConfigurationItemUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The contract response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ContractCreatePayload> Mutation(this XurrentClient client, ContractCreateInput input, ContractQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ContractCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing contract.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The contract response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ContractUpdatePayload> Mutation(this XurrentClient client, ContractUpdateInput input, ContractQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ContractUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<CustomCollectionCreatePayload> Mutation(this XurrentClient client, CustomCollectionCreateInput input, CustomCollectionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection element response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<CustomCollectionElementCreatePayload> Mutation(this XurrentClient client, CustomCollectionElementCreateInput input, CustomCollectionElementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionElementCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection element response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<CustomCollectionElementUpdatePayload> Mutation(this XurrentClient client, CustomCollectionElementUpdateInput input, CustomCollectionElementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionElementUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<CustomCollectionUpdatePayload> Mutation(this XurrentClient client, CustomCollectionUpdateInput input, CustomCollectionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// <br>This mutation can be used to push at most 100 discovered configuration items to Xurrent at once.</br>
        /// <br>A more extensive description of this functionality can be found on the</br>
        /// <br><see href="https://developer.xurrent.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</see>.</br>
        /// <br></br>
        /// <br>The query will be executed in the background. Typically the following fields should be queried:</br>
        /// <code>
        /// asyncQuery { resultUrl errorCount }
        /// configurationItems { id sourceID }
        /// </code>
        /// <br>On initial submission the <c>configurationItems</c> field will be <c>null</c>.</br>
        /// <br>The <c>resultUrl</c> contains an expiring link to the location where the resulting JSON is available</br>
        /// <br>once the query has been executed.</br>
        /// <br>It is possible to poll the link every couple of seconds to check whether the query is completed.</br>
        /// <br>Initially the link will point to an empty JSON document (<c>{}</c>), once the query is completed it will contain</br>
        /// <br>the JSON result of this mutation.</br>
        /// <br>In the result both the <c>asyncQuery</c> and <c>configurationItems</c> fields as requested on submission are present.</br>
        /// <br>The <c>errorCount</c> can for example be used to see whether processing was successful (then it is <c>0</c>).</br>
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The async query response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<DiscoveredConfigurationItemsPayload> Mutation(this XurrentClient client, DiscoveredConfigurationItemsInput input, AsyncQueryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new DiscoveredConfigurationItemsMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new effort class.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The effort class response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<EffortClassCreatePayload> Mutation(this XurrentClient client, EffortClassCreateInput input, EffortClassQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new EffortClassCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing effort class.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The effort class response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<EffortClassUpdatePayload> Mutation(this XurrentClient client, EffortClassUpdateInput input, EffortClassQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new EffortClassUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The first line support agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<FirstLineSupportAgreementCreatePayload> Mutation(this XurrentClient client, FirstLineSupportAgreementCreateInput input, FirstLineSupportAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new FirstLineSupportAgreementCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The first line support agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<FirstLineSupportAgreementUpdatePayload> Mutation(this XurrentClient client, FirstLineSupportAgreementUpdateInput input, FirstLineSupportAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new FirstLineSupportAgreementUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new holiday.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The holiday response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<HolidayCreatePayload> Mutation(this XurrentClient client, HolidayCreateInput input, HolidayQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new HolidayCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing holiday.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The holiday response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<HolidayUpdatePayload> Mutation(this XurrentClient client, HolidayUpdateInput input, HolidayQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new HolidayUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The invoice response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<InvoiceCreatePayload> Mutation(this XurrentClient client, InvoiceCreateInput input, InvoiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new InvoiceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing invoice.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The invoice response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<InvoiceUpdatePayload> Mutation(this XurrentClient client, InvoiceUpdateInput input, InvoiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new InvoiceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The knowledge article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<KnowledgeArticleCreatePayload> Mutation(this XurrentClient client, KnowledgeArticleCreateInput input, KnowledgeArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new KnowledgeArticleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The knowledge article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<KnowledgeArticleUpdatePayload> Mutation(this XurrentClient client, KnowledgeArticleUpdateInput input, KnowledgeArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new KnowledgeArticleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Adds a new note to a record.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The note response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<NoteCreatePayload> Mutation(this XurrentClient client, NoteCreateInput input, NoteQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new NoteCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Adds a new note reaction to a note.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The note reaction response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<NoteReactionCreatePayload> Mutation(this XurrentClient client, NoteReactionCreateInput input, NoteReactionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new NoteReactionCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes a note reaction from a note.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<NoteReactionDeleteMutationPayload> Mutation(this XurrentClient client, NoteReactionDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new NoteReactionDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new organization.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The organization response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<OrganizationCreatePayload> Mutation(this XurrentClient client, OrganizationCreateInput input, OrganizationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OrganizationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing organization.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The organization response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<OrganizationUpdatePayload> Mutation(this XurrentClient client, OrganizationUpdateInput input, OrganizationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OrganizationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new out of office period.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The out of office period response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<OutOfOfficePeriodCreatePayload> Mutation(this XurrentClient client, OutOfOfficePeriodCreateInput input, OutOfOfficePeriodQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OutOfOfficePeriodCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing out of office period.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The out of office period response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<OutOfOfficePeriodUpdatePayload> Mutation(this XurrentClient client, OutOfOfficePeriodUpdateInput input, OutOfOfficePeriodQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OutOfOfficePeriodUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new PDF design.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The pdf design response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<PdfDesignCreatePayload> Mutation(this XurrentClient client, PdfDesignCreateInput input, PdfDesignQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PdfDesignCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing PDF design.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The pdf design response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<PdfDesignUpdatePayload> Mutation(this XurrentClient client, PdfDesignUpdateInput input, PdfDesignQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PdfDesignUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new person.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The person response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<PersonCreatePayload> Mutation(this XurrentClient client, PersonCreateInput input, PersonQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PersonCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing person.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The person response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<PersonUpdatePayload> Mutation(this XurrentClient client, PersonUpdateInput input, PersonQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PersonUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new problem.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The problem response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProblemCreatePayload> Mutation(this XurrentClient client, ProblemCreateInput input, ProblemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProblemCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing problem.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The problem response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProblemUpdatePayload> Mutation(this XurrentClient client, ProblemUpdateInput input, ProblemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProblemUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new product backlog.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product backlog response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProductBacklogCreatePayload> Mutation(this XurrentClient client, ProductBacklogCreateInput input, ProductBacklogQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductBacklogCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing product backlog.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product backlog response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProductBacklogUpdatePayload> Mutation(this XurrentClient client, ProductBacklogUpdateInput input, ProductBacklogQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductBacklogUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new product category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProductCategoryCreatePayload> Mutation(this XurrentClient client, ProductCategoryCreateInput input, ProductCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing product category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProductCategoryUpdatePayload> Mutation(this XurrentClient client, ProductCategoryUpdateInput input, ProductCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProductCreatePayload> Mutation(this XurrentClient client, ProductCreateInput input, ProductQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProductUpdatePayload> Mutation(this XurrentClient client, ProductUpdateInput input, ProductQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectCategoryCreatePayload> Mutation(this XurrentClient client, ProjectCategoryCreateInput input, ProjectCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectCategoryUpdatePayload> Mutation(this XurrentClient client, ProjectCategoryUpdateInput input, ProjectCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectCreatePayload> Mutation(this XurrentClient client, ProjectCreateInput input, ProjectQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project risk level.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project risk level response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectRiskLevelCreatePayload> Mutation(this XurrentClient client, ProjectRiskLevelCreateInput input, ProjectRiskLevelQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectRiskLevelCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project risk level.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project risk level response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectRiskLevelUpdatePayload> Mutation(this XurrentClient client, ProjectRiskLevelUpdateInput input, ProjectRiskLevelQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectRiskLevelUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project task.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectTaskCreatePayload> Mutation(this XurrentClient client, ProjectTaskCreateInput input, ProjectTaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project task template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectTaskTemplateCreatePayload> Mutation(this XurrentClient client, ProjectTaskTemplateCreateInput input, ProjectTaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectTaskTemplateUpdatePayload> Mutation(this XurrentClient client, ProjectTaskTemplateUpdateInput input, ProjectTaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectTaskUpdatePayload> Mutation(this XurrentClient client, ProjectTaskUpdateInput input, ProjectTaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectTemplateCreatePayload> Mutation(this XurrentClient client, ProjectTemplateCreateInput input, ProjectTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectTemplateUpdatePayload> Mutation(this XurrentClient client, ProjectTemplateUpdateInput input, ProjectTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ProjectUpdatePayload> Mutation(this XurrentClient client, ProjectUpdateInput input, ProjectQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new release.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The release response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ReleaseCreatePayload> Mutation(this XurrentClient client, ReleaseCreateInput input, ReleaseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReleaseCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing release.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The release response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ReleaseUpdatePayload> Mutation(this XurrentClient client, ReleaseUpdateInput input, ReleaseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReleaseUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new request.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RequestCreatePayload> Mutation(this XurrentClient client, RequestCreateInput input, RequestQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new request template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RequestTemplateCreatePayload> Mutation(this XurrentClient client, RequestTemplateCreateInput input, RequestTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing request template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RequestTemplateUpdatePayload> Mutation(this XurrentClient client, RequestTemplateUpdateInput input, RequestTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing request.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RequestUpdatePayload> Mutation(this XurrentClient client, RequestUpdateInput input, RequestQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ReservationCreatePayload> Mutation(this XurrentClient client, ReservationCreateInput input, ReservationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ReservationOfferingCreatePayload> Mutation(this XurrentClient client, ReservationOfferingCreateInput input, ReservationOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationOfferingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ReservationOfferingUpdatePayload> Mutation(this XurrentClient client, ReservationOfferingUpdateInput input, ReservationOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationOfferingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ReservationUpdatePayload> Mutation(this XurrentClient client, ReservationUpdateInput input, ReservationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new risk.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RiskCreatePayload> Mutation(this XurrentClient client, RiskCreateInput input, RiskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new risk severity.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk severity response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RiskSeverityCreatePayload> Mutation(this XurrentClient client, RiskSeverityCreateInput input, RiskSeverityQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskSeverityCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk severity.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk severity response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RiskSeverityUpdatePayload> Mutation(this XurrentClient client, RiskSeverityUpdateInput input, RiskSeverityQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskSeverityUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<RiskUpdatePayload> Mutation(this XurrentClient client, RiskUpdateInput input, RiskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The scrum workspace response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ScrumWorkspaceCreatePayload> Mutation(this XurrentClient client, ScrumWorkspaceCreateInput input, ScrumWorkspaceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ScrumWorkspaceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The scrum workspace response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ScrumWorkspaceUpdatePayload> Mutation(this XurrentClient client, ScrumWorkspaceUpdateInput input, ScrumWorkspaceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ScrumWorkspaceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceCategoryCreatePayload> Mutation(this XurrentClient client, ServiceCategoryCreateInput input, ServiceCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceCategoryUpdatePayload> Mutation(this XurrentClient client, ServiceCategoryUpdateInput input, ServiceCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceCreatePayload> Mutation(this XurrentClient client, ServiceCreateInput input, ServiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service instance.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceInstanceCreatePayload> Mutation(this XurrentClient client, ServiceInstanceCreateInput input, ServiceInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceInstanceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service instance.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceInstanceUpdatePayload> Mutation(this XurrentClient client, ServiceInstanceUpdateInput input, ServiceInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceInstanceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service level agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceLevelAgreementCreatePayload> Mutation(this XurrentClient client, ServiceLevelAgreementCreateInput input, ServiceLevelAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceLevelAgreementCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service level agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceLevelAgreementUpdatePayload> Mutation(this XurrentClient client, ServiceLevelAgreementUpdateInput input, ServiceLevelAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceLevelAgreementUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceOfferingCreatePayload> Mutation(this XurrentClient client, ServiceOfferingCreateInput input, ServiceOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceOfferingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service offering.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceOfferingUpdatePayload> Mutation(this XurrentClient client, ServiceOfferingUpdateInput input, ServiceOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceOfferingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ServiceUpdatePayload> Mutation(this XurrentClient client, ServiceUpdateInput input, ServiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShopArticleCategoryCreatePayload> Mutation(this XurrentClient client, ShopArticleCategoryCreateInput input, ShopArticleCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article category.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShopArticleCategoryUpdatePayload> Mutation(this XurrentClient client, ShopArticleCategoryUpdateInput input, ShopArticleCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShopArticleCreatePayload> Mutation(this XurrentClient client, ShopArticleCreateInput input, ShopArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShopArticleUpdatePayload> Mutation(this XurrentClient client, ShopArticleUpdateInput input, ShopArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new shop order line.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop order line response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShopOrderLineCreatePayload> Mutation(this XurrentClient client, ShopOrderLineCreateInput input, ShopOrderLineQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopOrderLineCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop order line.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop order line response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShopOrderLineUpdatePayload> Mutation(this XurrentClient client, ShopOrderLineUpdateInput input, ShopOrderLineQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopOrderLineUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new short URL.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The short url response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShortUrlCreatePayload> Mutation(this XurrentClient client, ShortUrlCreateInput input, ShortUrlQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShortUrlCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing short URL.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The short url response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<ShortUrlUpdatePayload> Mutation(this XurrentClient client, ShortUrlUpdateInput input, ShortUrlQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShortUrlUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new site.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The site response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SiteCreatePayload> Mutation(this XurrentClient client, SiteCreateInput input, SiteQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SiteCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing site.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The site response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SiteUpdatePayload> Mutation(this XurrentClient client, SiteUpdateInput input, SiteQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SiteUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new skill pool.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The skill pool response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SkillPoolCreatePayload> Mutation(this XurrentClient client, SkillPoolCreateInput input, SkillPoolQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SkillPoolCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing skill pool.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The skill pool response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SkillPoolUpdatePayload> Mutation(this XurrentClient client, SkillPoolUpdateInput input, SkillPoolQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SkillPoolUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new SLA coverage group.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla coverage group response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SlaCoverageGroupCreatePayload> Mutation(this XurrentClient client, SlaCoverageGroupCreateInput input, SlaCoverageGroupQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaCoverageGroupCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing SLA coverage group.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla coverage group response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SlaCoverageGroupUpdatePayload> Mutation(this XurrentClient client, SlaCoverageGroupUpdateInput input, SlaCoverageGroupQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaCoverageGroupUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new SLA notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla notification scheme response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SlaNotificationSchemeCreatePayload> Mutation(this XurrentClient client, SlaNotificationSchemeCreateInput input, SlaNotificationSchemeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaNotificationSchemeCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing SLA notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla notification scheme response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SlaNotificationSchemeUpdatePayload> Mutation(this XurrentClient client, SlaNotificationSchemeUpdateInput input, SlaNotificationSchemeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaNotificationSchemeUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new sprint.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sprint response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SprintCreatePayload> Mutation(this XurrentClient client, SprintCreateInput input, SprintQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SprintCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing sprint.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sprint response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SprintUpdatePayload> Mutation(this XurrentClient client, SprintUpdateInput input, SprintQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SprintUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new survey.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SurveyCreatePayload> Mutation(this XurrentClient client, SurveyCreateInput input, SurveyQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new survey response.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SurveyResponseCreatePayload> Mutation(this XurrentClient client, SurveyResponseCreateInput input, SurveyResponseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyResponseCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey response.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SurveyResponseUpdatePayload> Mutation(this XurrentClient client, SurveyResponseUpdateInput input, SurveyResponseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyResponseUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<SurveyUpdatePayload> Mutation(this XurrentClient client, SurveyUpdateInput input, SurveyQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TaskCreatePayload> Mutation(this XurrentClient client, TaskCreateInput input, TaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new task template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TaskTemplateCreatePayload> Mutation(this XurrentClient client, TaskTemplateCreateInput input, TaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing task template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TaskTemplateUpdatePayload> Mutation(this XurrentClient client, TaskTemplateUpdateInput input, TaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TaskUpdatePayload> Mutation(this XurrentClient client, TaskUpdateInput input, TaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The team response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TeamCreatePayload> Mutation(this XurrentClient client, TeamCreateInput input, TeamQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TeamCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing team.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The team response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TeamUpdatePayload> Mutation(this XurrentClient client, TeamUpdateInput input, TeamQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TeamUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new time allocation.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time allocation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TimeAllocationCreatePayload> Mutation(this XurrentClient client, TimeAllocationCreateInput input, TimeAllocationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeAllocationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing time allocation.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time allocation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TimeAllocationUpdatePayload> Mutation(this XurrentClient client, TimeAllocationUpdateInput input, TimeAllocationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeAllocationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new time entry.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time entry response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TimeEntryCreatePayload> Mutation(this XurrentClient client, TimeEntryCreateInput input, TimeEntryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeEntryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing time entry.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time entry response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TimeEntryUpdatePayload> Mutation(this XurrentClient client, TimeEntryUpdateInput input, TimeEntryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeEntryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The timesheet setting response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TimesheetSettingCreatePayload> Mutation(this XurrentClient client, TimesheetSettingCreateInput input, TimesheetSettingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimesheetSettingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The timesheet setting response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TimesheetSettingUpdatePayload> Mutation(this XurrentClient client, TimesheetSettingUpdateInput input, TimesheetSettingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimesheetSettingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new translation.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The translation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TranslationCreatePayload> Mutation(this XurrentClient client, TranslationCreateInput input, TranslationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TranslationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing translation.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The translation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<TranslationUpdatePayload> Mutation(this XurrentClient client, TranslationUpdateInput input, TranslationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TranslationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new UI extension.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The ui extension response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<UiExtensionCreatePayload> Mutation(this XurrentClient client, UiExtensionCreateInput input, UiExtensionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new UiExtensionCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing UI extension.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The ui extension response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<UiExtensionUpdatePayload> Mutation(this XurrentClient client, UiExtensionUpdateInput input, UiExtensionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new UiExtensionUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new waiting for customer follow-up.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The waiting for customer follow up response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WaitingForCustomerFollowUpCreatePayload> Mutation(this XurrentClient client, WaitingForCustomerFollowUpCreateInput input, WaitingForCustomerFollowUpQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WaitingForCustomerFollowUpCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing waiting for customer follow-up.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The waiting for customer follow up response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WaitingForCustomerFollowUpUpdatePayload> Mutation(this XurrentClient client, WaitingForCustomerFollowUpUpdateInput input, WaitingForCustomerFollowUpQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WaitingForCustomerFollowUpUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WebhookCreatePayload> Mutation(this XurrentClient client, WebhookCreateInput input, WebhookQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WebhookDeleteMutationPayload> Mutation(this XurrentClient client, WebhookDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook policy create response response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WebhookPolicyCreatePayload> Mutation(this XurrentClient client, WebhookPolicyCreateInput input, WebhookPolicyCreateResponseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes a webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WebhookPolicyDeleteMutationPayload> Mutation(this XurrentClient client, WebhookPolicyDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook policy response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WebhookPolicyUpdatePayload> Mutation(this XurrentClient client, WebhookPolicyUpdateInput input, WebhookPolicyQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WebhookUpdatePayload> Mutation(this XurrentClient client, WebhookUpdateInput input, WebhookQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WorkflowCreatePayload> Mutation(this XurrentClient client, WorkflowCreateInput input, WorkflowQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WorkflowTemplateCreatePayload> Mutation(this XurrentClient client, WorkflowTemplateCreateInput input, WorkflowTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow template.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WorkflowTemplateUpdatePayload> Mutation(this XurrentClient client, WorkflowTemplateUpdateInput input, WorkflowTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow type.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow type response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WorkflowTypeCreatePayload> Mutation(this XurrentClient client, WorkflowTypeCreateInput input, WorkflowTypeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTypeCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow type.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow type response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WorkflowTypeUpdatePayload> Mutation(this XurrentClient client, WorkflowTypeUpdateInput input, WorkflowTypeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTypeUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="client">The <see cref="XurrentClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="XurrentException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="XurrentException"></exception>
        public static async Task<WorkflowUpdatePayload> Mutation(this XurrentClient client, WorkflowUpdateInput input, WorkflowQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowUpdateMutation(input, query), throwOnError);
        }
    }
}
