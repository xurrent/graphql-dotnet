using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Creates a new site.
    /// </summary>
    internal sealed class SiteCreateMutation : Mutation<SiteCreatePayload, SiteCreateInput>
    {
        /// <summary>
        /// Initialize an new SiteCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The site response query.</param>
        internal SiteCreateMutation(SiteCreateInput data, SiteQuery query)
            : base("siteCreate", "SiteCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The site response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SiteQuery query)
        {
            query.FieldName = "site";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
