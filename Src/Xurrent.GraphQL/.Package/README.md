# Xurrent GraphQL .NET SDK

The Xurrent GraphQL .NET SDK enables seamless integration with the [Xurrent GraphQL API](https://developer.xurrent.com/graphql) in .NET applications. It supports querying, mutations, pagination, filtering, attachments, and bulk operations.

## Installation

The package is available on [NuGet](https://www.nuget.org/packages/Xurrent.GraphQL):

```bash
dotnet add package Xurrent.GraphQL
```

## Features

- Query and mutate data via Xurrent GraphQL.
- Supports OAuth 2.0 and Personal Access Token authentication.
- Handles pagination, filtering, and complex nested queries.
- Upload and manage attachments.
- Bulk import/export functionality.
- Customizable tracing for debugging.
- Manage multiple authentication tokens and accounts.

## Getting Started

### Quick Start Example

```csharp
using Xurrent.GraphQL;

AuthenticationToken token = new AuthenticationToken("clientID", "clientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Production, EnvironmentRegion.EU);
Person me = await client.Me();
Console.WriteLine($"{me.Name} ({me.PrimaryEmail})");
```

### Query Example

```csharp
DataList<Person> people = await client.Get(Query.Person
    .Select(PersonField.ID, PersonField.Name)
    .SelectOrganization(new OrganizationQuery()
        .Select(OrganizationField.ID, OrganizationField.Name)));
```

### Mutation Example

```csharp
PersonCreateInput input = new()
{
    Name = "Michael",
    PrimaryEmail = "michael@company.com"
};
PersonCreatePayload result = await client.Mutation(input, new PersonQuery().Select(PersonField.ID));
```

## Advanced Usage

### Pagination and Nested Queries

The SDK automatically handles pagination. Here's an example of querying with pagination and nested objects:

```csharp
IQuery query = Query.Person
    .Select(PersonField.ID, PersonField.Name)
    .ItemsPerRequest(50)
    .SelectTeams(Query.Team);
DataList<Person> people = await client.Get(query);
```

### Bulk Import/Export

Export data to CSV or Excel format, or import data via the Bulk API:

```csharp
string token = await client.Bulk.StartCsvExport("cis");
await client.Bulk.AwaitDownloadAndSave(token, 5, @"./cis.csv");
```

### Attachments

Upload an attachment and link it to a request:

```csharp
using (Stream stream = File.OpenRead("image.png"))
{
    AttachmentUploadResponse attachment = await client.UploadAttachment(stream, "image.png", "image/png");
    // Associate the attachment with a request or other entity.
}
```

### Exception Handling

```csharp
try
{
    var result = await client.Mutation(new PersonUpdateInput { ID = "person-id" }, new PersonQuery().Select(PersonField.ID));
}
catch (XurrentException ex)
{
    Console.WriteLine(ex.Message);
}
```

## Documentation

For detailed usage, please refer to the following resources:
- Full [Xurrent GraphQL API Documentation](https://developer.xurrent.com/graphql).
- Additional examples and usage details in the [GitHub README](https://github.com/xurrent/graphql-dotnet).
