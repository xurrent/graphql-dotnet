using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/archive/">Archive</see> object.
    /// </summary>
    public class Archive : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The archived record.
        /// </summary>
        [JsonProperty("archived"), XurrentField(IsDefaultQueryProperty = true)]
        public IHasLifeCycleState? Archived { get; internal set; }

        /// <summary>
        /// The person who archived the record.
        /// </summary>
        [JsonProperty("archivedBy"), XurrentField(IsDefaultQueryProperty = true)]
        public Person? ArchivedBy { get; internal set; }

        /// <summary>
        /// The date and time at which the archive was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
