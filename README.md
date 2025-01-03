# .NET SDK for Xurrent GraphQL
A .NET and .NET Framework client for accessing the [Xurrent GraphQL API](https://developer.xurrent.com/graphql/).

## Table of Contents
- [NuGet](#nuget)
- [Introduction](#introduction)
- [Client](#client)
- [Querying](#querying)
  - [Filtering](#filtering)
  - [Views](#views)
  - [Pagination](#pagination)
  - [Date and Time Exceptions](#date-and-time-exceptions)
  - [Interface-Based Properties](#interface-based-properties)
- [Mutations](#mutations)
  - [Response](#response)
  - [Exception](#exception)
- [Attachments](#attachments)
- [Events API](#events-api)
- [Bulk API](#bulk-api)
- [Multiple Authentication Tokens](#multiple-authentication-tokens)
- [Multiple Accounts](#multiple-accounts)
- [Response Timing](#response-timing)
- [Trace Capabilities](#trace-capabilities)
- [Examples](#examples)
  - [Minimum Example](#minimum-example)
  - [Queries](#queries)
  - [Mutations](#mutations-1)
  - [Attachments](#attachments-1) 
  - [Create a New Event via the Events API](#create-a-new-event-via-the-events-api)
  - [Bulk Import and Export](#bulk-import-and-export)
  - [Exception Handling](#exception-handling)
  - [Authentication Tokens](#authentication-tokens)
  - [Multiple Accounts](#multiple-accounts-1)
  - [Multiple Authentication Tokens](#multiple-authentication-tokens-1)
  - [Trace Output](#trace-output)

## NuGet
Stable binaries are published to [NuGet.org](https://www.nuget.org), and contain everything you need to use [.NET SDK for Xurrent GraphQL](https://www.nuget.org/packages/Xurrent.GraphQL) in your application.

## Introduction
The .NET SDK simplifies the process of interacting with the Xurrent GraphQL API, allowing you to take full advantage of its query and mutation capabilities with ease. It abstracts away the complex task of managing low-level details such as sending requests, parsing responses, filtering, and pagination, making it simple to integrate Xurrent GraphQL API into your .NET application and fully leverage its functionalities.

For a general introduction to the GraphQL query language please see [graphql.org](https://graphql.org/), and for a Xurrent-specific introduction see [Xurrent GraphQL Training](https://learning.xurrent.com/integrations_graphql/).

The data entities in the module are modeled after the Xurrent Quality Assurance GraphQL schema, which may include objects or properties that are not yet available in production.

## Client
The `XurrentClient` class provides access to all the necessary methods for querying and modifying data. With the `Get` and `Mutation` methods, there are five properties that allow for default behavior customization.
- The `AccountID` property to update the Xurrent Account ID after initializing the `XurrentClient`, allowing switching between accounts using the same client.
- The `EnumeratorTolerantSerializer` is set to `true` by default, allowing the client to handle unmappable enumerator values gracefully by returning `null` or a default value instead of raising an error.
- The `DefaultItemsPerRequest` property sets the number of items per connection request, with a default and maximum value of 100.
- The `MaximumRecursiveRequests` property controls the number of recursive requests that the client can make when pagination occurs in the top level query. The default value is 10.
- The `MaximumQueryDepthLevelConnections` property controls the depth of nested queries. While it is possible to increase this limit, it can negatively affect performance. The default value is 2.

## Authentication
The SDK supports both Personal Access Token and OAuth 2.0 Client Credential Grant authentication methods. It automatically renews the token 1 minute before it expires when using OAuth 2.0 Client Credential Grant.

## Querying
The SDK provides a simple and intuitive way to write queries, allowing you to easily retrieve the data you need.
The query interface also enables you to write nested queries, making it simple to work with related data.
You can easily execute complex queries and retrieve data with minimal effort, making it simple to build efficient and performant applications that leverage the full capabilities of the Xurrent GraphQL API.

### Filtering
You can easily apply filters on root connections when creating a query, making it simple to retrieve specific data.
This feature allows you to limit the results returned by the query by adding conditions to the fields you are querying.
This way you can filter the results based on specific values or ranges, making it easy to find the data you need.

### Views
In addition to the filtering capabilities, the SDK also allows you to specify the scope of your query by using the view argument on the root connections.
The view argument allows you to target a specific set of data. By default, it is set to the current account, but it can also be used to query all accounts or another predefined subset of data for that specific data entity. 

### Pagination
The SDK takes care of pagination for you. The maximum number of items returned per connection is 100.
If your query returns more than 100 items on a connection, it will automatically retrieve the next 100 items without the need to write a new query, thus making it easy to work with large datasets.

### Date and Time Exceptions
The Xurrent GraphQL API has a data type called `ISO8601Timestamp` which includes three non-datetime values: `best_effort`, `no_target`, and `clock_stopped` that cannot be converted to a standard date and time format. To handle these values, the API's SDK includes a custom `JsonConverter` that converts the exception values to specific date and time values:
- `best_effort` is converted to the date and time value of `0001-01-01 01:01:01.111`
- `no_target` is converted to `0002-02-02 02:02:02.222`
- `clock_stopped` is converted to `0003-03-03 03:03:03.333`

These specific values can be accessed through the `DateTimeValue` class.

### Interface-Based Properties
Certain properties return objects that conform to an interface, providing flexibility in the variety of objects they can provide.
To obtain a specific object type from an interface-based property, it's crucial to indicate the desired type in the select statement of the query. Without specifying a type in the select statement, the property will return `null`.
The SDK facilitates querying such properties by allowing multiple select statements. This feature enables the retrieval of diverse sets of values for each object.

## Mutations
Mutations are used to create, update, or delete data. Like queries, the SDK provides a simple and intuitive way to perform mutations.


### Response
Any mutation, except for delete operations, will return the newly created or updated object.
This means that a mutation also requires a query to specify the fields that should be returned. The response cannot contain any `connections`.

### Exception
For mutations, you can specify how error handling should behave. By default, mutations throw an exception when an error occurs.
Alternatively, you can configure the mutation to return the object and use the `IsError` method to check for errors.

## Attachments
The SDK features an `UploadAttachment` method for easily uploading attachments, which can later be associated with any create or update mutation.
The response from this request includes information necessary for linking these attachments.

## Events API
The .NET SDK provides access to the Xurrent Events REST API. For more information, please visit the [Xurrent developer pages](https://developer.xurrent.com/v1/requests/events/).

## Bulk API
The .NET SDK provides access to the Xurrent Bulk REST API, enabling data import and export. For more information, please visit the [Xurrent developer pages](https://developer.xurrent.com/v1/bulk/).

## Multiple Authentication Tokens
The client allows for the use of multiple authentication tokens. A single token is limited to 3600 API requests per hour or 5000 points per hour for Query Cost. In some situations, this may not be sufficient.
When there are multiple tokens in use, the client will always select the token with the most remaining requests to use. More information about [Rate Limiting](https://developer.xurrent.com/graphql/#request-rate-limits) and [Query Cost Limits](https://developer.xurrent.com/graphql/#query-cost-limit) can be found on the [Xurrent developer website](https://developer.xurrent.com/graphql).

## Multiple Accounts
When connecting to multiple accounts within a single application, it is recommended to use multiple `XurrentClient` instances.
While the `AccountID` can be set via the `XurrentClient.AccountID`, using the same client instance to execute multiple requests simultaneously across different accounts can lead to potential issues and unexpected behavior.
To ensure effective management of multiple accounts, it's advisable to utilize a dictionary structure. For further information, please refer to the [example](#multiple-accounts-1).

## Response Timing
The Xurrent GraphQL API limits the number of requests to 20 per 2 seconds. The SDK will keep track of the response time and lock the process to make sure it takes at least 100 milliseconds per request.

## Trace Capabilities
The [Trace class](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.trace) is used to produce detailed information about the GraphQL query or mutation. [Trace Listeners](https://learn.microsoft.com/en-us/dotnet/framework/debug-trace-profile/trace-listeners) can be used to gather detailed information that can be helpful for debugging during release or for auditing purposes.
Each request produces two entries with identical identifiers � the initial one containing the account ID, the HTTP verb, the URL, and the content, while the second includes the API response time in milliseconds.

# Examples

## Minimum Example
```csharp
using Xurrent.GraphQL;

AuthenticationToken token = new AuthenticationToken("clientID", "clientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Production, EnvironmentRegion.EU);
Person me = await client.Me();
Console.WriteLine($"{me.Name} ({me.PrimaryEmail})");
```

## Queries

### Get People
```csharp
DataList<Person> people = await client.Get(Query.Person
    .Select(PersonField.ID, PersonField.Organization, PersonField.Name, PersonField.CustomFields));
```
You must always specify the fields to include in the response.
In the example, fields like `ID`, `Organization`, `Name`, and `CustomFields`.

```csharp
DataList<Person> people = await client.Get(Query.Person
    .Select(PersonField.ID, PersonField.Name)
        .SelectOrganization(new OrganizationQuery()
            .Select(OrganizationField.ID, OrganizationField.Name, OrganizationField.Disabled)));
```
To further refine the selection of fields by using a query for a specific GraphQL Object type field, in this case, `Organization`.
By using the `SelectOrganization` method on the `Query.Person` object, you can specify the fields to include for the `Organization` field.
The example demonstrates the selection of fields like `ID`, `Name`, and `Disabled` for the `Organization` field.

#### All Fields
```csharp
DataList<Person> people = await client.Get(Query.Person.SelectAll());
```

`SelectAll()` should only be used for debugging purposes as it may include fields that are not yet available in production and can negatively impact performance.
It's recommended to only select the necessary fields.

### Get All People in the Directory and Support Domain Accounts
```csharp
DataList<Person> people = await client.Get(Query.Person.View(PersonView.All));
```
A view can only be used on the top level query.

#### Nested Queries and Items per Request
```csharp
PersonQuery query = Query.Person
    .Select(PersonField.ID, PersonField.Name)
    .ItemsPerRequest(10)
    .SelectTeams(Query.Team)
    .SelectSkillPools(Query.SkillPool
        .SelectMembers(Query.Person
            .SelectConfigurationItems(Query.ConfigurationItem
                .Select(ConfigurationItemField.ID, ConfigurationItemField.Label, ConfigurationItemField.Name))));

client.MaximumQueryDepthLevelConnections = 4;
DataList<Person> people = await client.Get(query);
```

The default, and maximum, number of items per connection is 100, the maximum number of items that can be returned in a single request with multiple connections is limited to 500,000.
When querying nested data, such as 100 people with 100 skill pools and 100 members each, the total number of items (100 x 100 x 100) exceeds the maximum of 500,000.
Therefore, specifying the number of items per request is important to avoid exceeding this limit.

The default maximum depth for nested queries is 2. While it is possible to increase this limit, doing so can affect performance when pagination applies on the `Members` their `ConfigurationItems`.

```csharp
client.MaximumQueryDepthLevelConnections = 5;
```

### Filtering
There are three methods to filtering: `Filter`, `CustomFilter`, and `FreeFormatFilter`.
Filters can only be applied at the top level of the query.

#### Filter
The `Filter` method allows you to specify field filters at the top level of the query.
You can define the field, the operator (e.g., equals, not equals), and the value to match against.
```csharp
PersonQuery query = Query.Person.Filter(PersonFilter.Name, FilterOperator.Equals, "Howard");
```

#### Filter by ID
The `ID` filtering allows you to search for an object based on its unique ID.
When using the `ID` filter, any additional filters and view selections will be ignored.
It is recommended to use the ID filter instead of the `.Filter(PersonFilter.ID, FilterOperator.Equals, "")` approach, as it provides an average response time improvement of approximately 15%.
```csharp
PersonQuery query = new PersonQuery("NG1lLnFhL1blcnNvbi8yMjMxSjIx");
```

#### Custom Filter
The `CustomFilter` method enables the use of existing custom filters.
```csharp
PersonQuery query = new PersonQuery()
    .CustomFilter("Age", FilterOperator.NotEquals, new string[] { null });
```

#### Free Format Filter
The `FreeFormatFilter` method enables the usage of same filter functionality available in the top screen filter in the user interface (UI).
```csharp
PersonQuery query = new PersonQuery()
    .FreeFormatFilter("Howard");
```

### Sorting
```csharp
PersonQuery query = Query.Person.OrderBy(PersonOrderField.Name, OrderBySortOrder.Ascending);
```
Sorting can only be used on the top level query.

### Nested Query with Filtering and Sorting
```csharp
PersonQuery query = new PersonQuery()
    .View(PersonView.All)
    .OrderBy(PersonOrderField.Vip, OrderBySortOrder.Descending)
    .Filter(PersonFilter.CreatedAt, FilterOperator.GreaterThanOrEqualsTo, new DateTime(2020, 1, 1))
    .SelectContacts(new ContactQuery()
        .SelectAll())
    .SelectPermissions(new PermissionQuery()
        .ItemsPerRequest(10)
        .Select(PermissionField.Account, PermissionField.Roles))
    .SelectTeams(new TeamQuery()
        .ItemsPerRequest(10)
        .SelectConfigurationManager(new PersonQuery()
            .Select(PersonField.Name, PersonField.EmployeeID))
        .SelectMembers(new PersonQuery()
            .ItemsPerRequest(50)
            .Select(PersonField.Name)))
    .SelectConfigurationItems(new ConfigurationItemQuery()
        .Select(ConfigurationItemField.Label)
        .ItemsPerRequest(10)
        .SelectRequests(new RequestQuery()
            .ItemsPerRequest(10)
            .Select(RequestField.Subject, RequestField.Supplier)));

DataList<Person> people = await client.Get(query);
```

### Interface-Based Properties
Retrieve all archived properties and cast only those belonging to `Person`, `Request`, or `Task` types, each with their unique properties.
```csharp
DataList<Archive> archives = await client.Get(Query.Archive
    .SelectArchived(new PersonQuery()
        .Select(PersonField.ID, PersonField.Name, PersonField.PrimaryEmail))
    .SelectArchived(new RequestQuery()
        .Select(RequestField.ID, RequestField.RequestId))
    .SelectArchived(new TaskQuery()
        .Select(TaskField.ID, TaskField.Subject)
            .SelectWorkflow(new WorkflowQuery()
                .Select(WorkflowField.ID, WorkflowField.Subject)))
    );
```

## Mutations

### Create a New Person and Return the ID
```csharp
CustomFieldCollection customFields = new();
customFields.AddOrUpdate("internal_reference", "an internal reference");

PersonCreateInput input = new() {
    Name = "Michael",
    PrimaryEmail = "Michael@company.com",
    Disabled= true,
    CustomFields = customFields,
    EmployeeID = "123",
    TeamIds = new() { "NG1lLnFhL1RlYW0vMjA1MTQ", "NG1lLnFhL1RlYW0vMjA1MGv" },
    Source = "Xurrent.GraphQL",
    TimeFormat24h = true,
    TimeZone = "Brussels",
    DoNotTranslateLanguages = new() { "en", "nl" }
};

PersonCreatePayload result = await client.Mutation(input, new PersonQuery().Select(PersonField.ID), false);
if (result.IsError())
{
    Debug.WriteLine(result.Errors?.ToString());
    return;
}

Person newPerson = result.Person!;
```

### Updating an Existing Person and Return the ID, Name and Site
```csharp
try
{
    PersonUpdatePayload result = await client.Mutation(new PersonUpdateInput
    {
        ID = "NG1lLnFhL1blcnNvbi8yMjMxSjIx",
        Name = "Jimmy",
        PrimaryEmail = "jimmy@company.com",
    }, new PersonQuery().Select(PersonField.ID, PersonField.Name, PersonField.Site), true).Result;

    Person updatedPerson = result.Person;
}
catch (XurrentException ex)
{
    Debug.WriteLine(ex.Message);
}
```

### Updating the Custom Fields of an Existing Person
```csharp
DataList<Person> people = await client.Get(
    new PersonQuery("NG1lLnFhL1blcnNvbi8yMjMxSjIx")
        .Select(PersonField.CustomFields)
    );

Person person = people.First();
person.CustomFields!.AddOrUpdate("internal_reference", "none");           

PersonUpdatePayload result = await client.Mutation(new PersonUpdateInput()
{
    ID = person.ID,
    CustomFields = person.CustomFields
}, new PersonQuery().Select(PersonField.ID));
```

Only the custom fields provided will be added or updated; all other non-specified custom fields remain unchanged.
Custom fields cannot be removed; once added, they can only be updated or set to `null`.
For example, if an object contains two custom fields, `start_date` and `leave_date`, and only the `start_date` is provided in an update, the `leave_date` remains untouched.

## Attachments

### Add an Attachment to a Request
```csharp
using (HttpClient httpClient = new())
{
    using (HttpResponseMessage responseMessage = await httpClient.GetAsync("https://www.xurrent.com/wp-content/uploads/2024/10/xurrent-logo-web.png"))
    {
        using (Stream stream = await responseMessage.Content.ReadAsStreamAsync())
        {
            AttachmentUploadResponse response = await client.UploadAttachment(stream, "xurrent-logo-web.png", "image/png");

            DataList<Request> requests = await client.Get(new RequestQuery("NG1lLnFhL1nNvb4MjMxSjIx"));
            if (requests.Any())
            {
                RequestUpdatePayload updatedRequest = await client.Mutation(new RequestUpdateInput()
                {
                    ID = requests.First().ID,
                    Note = "[Easy - Advanced - Complete](https://www.xurrent.com/)",
                    NoteAttachments = new List<AttachmentInput>()
                    {
                        new AttachmentInput
                        {
                            Key = response.Key,
                            Size = response.Size,
                            Inline = false
                        }
                    }
                }, new RequestQuery().Select(RequestField.ID));
            }
        }
    }
}
```

### Upload an Inline Attachment
```csharp
DataList<Request> requests = await client.Get(new RequestQuery()
    .Select(RequestField.ID)
    .Filter(RequestFilter.ID, FilterOperator.Equals, "123"));

if (requests.Any())
{
    AttachmentUploadResponse attachment = await client.UploadAttachment(@".\image.png", "image/png");
    RequestUpdatePayload updatedRequest = await client.Mutation(new RequestUpdateInput()
    {
        ID = requests.First().ID,
        Note = $"This is an embedded image.\n![]({attachment.Key})",
        NoteAttachments = new List<AttachmentInput>
        {
            new AttachmentInput
            {
                Key = attachment.Key,
                Size = attachment.Size,
                Inline = true
            }
        }
    }, new RequestQuery().Select(RequestField.ID));
}
```

## Create a New Event via the Events API
```csharp
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

Request request = await client.CreateEvent(requestCreate);
```
Note that the Xurrent Events API operates as a REST API, not GraphQL. The response is transformed into the GraphQL `Request` object.

## Bulk Import and Export
The Bulk API lets you export CSV and Excel files, and import CSV files.

### Excel Export
Start an Excel export of the configuration items and people, waits until the export completes, and saves the file.
```csharp
string token = await client.Bulk.StartXlsxExport("cis", "people");
await client.Bulk.AwaitDownloadAndSave(token, 5, @".\export.zip");
```

### CSV Export
Start a CSV export of the configuration items, waits until the export completes, and saves the file.
```csharp
string token = client.Bulk.StartCsvExport(DateTime.Now.AddMonths(1), ExportLineSeparator.LineFeed, "cis");
await client.Bulk.AwaitDownloadAndSave(token, 5, @".\cis.csv");
```

### Import
Start an import, waits for the completion, and writes the output to the console.
```csharp
string token = client.Bulk.StartImport("cis", @".\cis_import_.csv").Result;
BulkImportResponse response = client.Bulk.AwaitImport(token, 5).Result;
if (response.State == ImportExportStatus.Done)
{
    Console.WriteLine($"  Created: {response.Results.Created}");
    Console.WriteLine($"   Update: {response.Results.Updated}");
    Console.WriteLine($"  Deleted: {response.Results.Deleted}");
    Console.WriteLine($" Failures: {response.Results.Failures}");
    Console.WriteLine($"Unchanged: {response.Results.Unchanged}");
}
```

## Exception Handling
```csharp
try
{
    var result = client.Mutation(new PersonUpdateInput()
    {
        ID = person.ID,
        CustomFields = person.CustomFields
    }, false).Result;

    Console.WriteLine(result.Errors.First());
}
catch (XurrentException ex)
{
    Console.WriteLine(ex.Message);
}
```
By default the SDK will throw an new exception. The mutation method has one additional argument `throwOnError`, when false the `result` property will contain the error messages.

## Authentication Tokens
```csharp
AuthenticationTokenCollection tokens = new AuthenticationTokenCollection()
{
    new AuthenticationToken("OAuth 2.0 Client Credential Client ID", "OAuth 2.0 Client Credential Client Secret"),
    new AuthenticationToken("A personal access token")
};

XurrentClient client = new(tokens, "account-name", EnvironmentType.Demo, EnvironmentRegion.EU);
client.AccountID = "new-account-name";
```

## Multiple Accounts
To ensure effective management of multiple accounts, it's recommended to employ a dictionary structure.
This structure facilitates mapping each account to its corresponding `XurrentClient` instance.
```csharp
Dictionary<string, XurrentClient> clients = new()
{
    { "account-1", new XurrentClient(new AuthenticationTokenCollection() { ... }, "account-1", EnvironmentType.Production, EnvironmentRegion.EU) },
    { "account-2", new XurrentClient(new AuthenticationTokenCollection() { ... }, "account-2", EnvironmentType.Production, EnvironmentRegion.EU) },
    { "account-3", new XurrentClient(new AuthenticationTokenCollection() { ... }, "account-3", EnvironmentType.Production, EnvironmentRegion.EU) }
};

await clients["account-1"].Get(new AccountQuery().Select(AccountField.ID));
```

## Multiple Authentication Tokens
In the context of multiple Xurrent authentication tokens, request and cost scores are essential metrics used to determine the priority of tokens when making API requests. These scores help prioritize tokens efficiently by considering two critical factors.

**Request Score:**
This weight, with a default value of 0.6, controls the significance of remaining API requests in the score calculation.
Adjusting this weight influences the sorting of tokens to favor those with more available requests.
A higher `RequestWeight` places more emphasis on tokens with a larger number of remaining API requests.

**Cost Score:**
With a default value of 0.4, the cost weight determines the influence of remaining cost associated with using an authentication token.
Modifying this weight allows you to give preference to tokens with more remaining cost.
A higher `CostWeight` makes tokens with more remaining cost significant during the selection process.

These weights are user-configurable and allow for fine-tuning the token sorting process according to specific requirements.

```csharp
client.ConfigureAuthenticationTokenWeight(requestWeight: 0.5, costWeight: 0.5);
```

To learn more about GraphQL Service Quotas, refer to the [Service Quota](https://developer.xurrent.com/graphql/#service-quotas-1) section, and for information on Rate Limiting, explore the [Rate Limiting](https://developer.xurrent.com/v1/#rate-limiting) section in the Xurrent developer documentation.

## Trace Output
A trace output providing details of a GraphQL query request and response time.
```json
{"id":"b1685ff0-6356-49eb-ab58-6ef32b9b4a61","method":"POST","uri":"https://graphql.xurrent.qa/","content":"{\"query\":\"query{node(id: \\\"KG1jIx\\\") {... on Person {id}}}\"}","account_id":"account-name"}
{"id":"b1685ff0-6356-49eb-ab58-6ef32b9b4a61","response_time_in_ms":44}
```