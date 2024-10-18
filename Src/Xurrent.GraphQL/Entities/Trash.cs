using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/trash/">Trash</see> object.
    /// </summary>
    public class Trash : Node
    {
        /// <summary>
        /// The account of the trashed record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the trash was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// </summary>
        [JsonProperty("trashed"), XurrentField(IsDefaultQueryProperty = true)]
        public IHasLifeCycleState? Trashed { get; internal set; }

        /// <summary>
        /// The person who trashed the record.
        /// </summary>
        [JsonProperty("trashedBy"), XurrentField(IsDefaultQueryProperty = true)]
        public Person? TrashedBy { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
