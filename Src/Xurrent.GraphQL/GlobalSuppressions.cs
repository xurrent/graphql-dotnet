// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
[assembly: SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "Traditional 'using' statement for clarity")]
[assembly: SuppressMessage("Style", "IDE0130:Namespace does not match folder structure", Justification = "Folder are use to organize the code, not the namespace structure", Scope = "namespace", Target = "~N:Xurrent.GraphQL")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "The Xurrent object is named CustomCollection in the GraphQL API.", Scope = "type", Target = "~T:Xurrent.GraphQL.CustomCollection")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "The Xurrent object is named Permission in the GraphQL API.", Scope = "type", Target = "~T:Xurrent.GraphQL.Permission")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Suppressed to maintain instance method design. Ensures consistency in API design and allows for potential future instance-specific functionality.", Scope = "member", Target = "~M:Xurrent.GraphQL.XurrentBulkClient.Download(Xurrent.GraphQL.BulkExportResponse)~System.Threading.Tasks.Task{System.IO.Stream}")]

#if NET6_0_OR_GREATER

[assembly: SuppressMessage("Reliability", "CA2016:Forward the 'CancellationToken' parameter to methods", Justification = "ReadAsStringAsync does not support CancellationToken.", Scope = "member", Target = "~M:Xurrent.GraphQL.XurrentClient.GetImportExportStatus``1(System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task{``0}")]
[assembly: SuppressMessage("Maintainability", "CA1510:Use ArgumentNullException throw helper", Justification = "Suppressed due to multi-target framework compatibility. The project builds for .NET 6, .NET 4.7.2, and .NET Standard 2.0, which do not support ArgumentNullException.ThrowIfNull. Ensures compatibility across all target frameworks.", Scope = "member", Target = "~M:Xurrent.GraphQL.XurrentBulkClient.StartImport(System.String,System.String,System.IO.Stream)~System.Threading.Tasks.Task{System.String}")]

#endif
