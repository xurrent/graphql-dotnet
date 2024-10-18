using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Creates a new custom collection.
    /// </summary>
    internal sealed class CustomCollectionCreateMutation : Mutation<CustomCollectionCreatePayload, CustomCollectionCreateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The custom collection response query.</param>
        internal CustomCollectionCreateMutation(CustomCollectionCreateInput data, CustomCollectionQuery query)
            : base("customCollectionCreate", "CustomCollectionCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The custom collection response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(CustomCollectionQuery query)
        {
            query.FieldName = "customCollection";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
