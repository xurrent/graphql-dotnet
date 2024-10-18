using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/asyncquery/">AsyncQuery</see> object.
    /// </summary>
    public class AsyncQuery : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was set to the status <c>completed</c>.
        /// </summary>
        [JsonProperty("completedAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of errors encountered during the execution.
        /// </summary>
        [JsonProperty("errorCount"), XurrentField(IsDefaultQueryProperty = true)]
        public long? ErrorCount { get; internal set; }

        /// <summary>
        /// The person or application who created the async query.
        /// </summary>
        [JsonProperty("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The number of affected records.
        /// </summary>
        [JsonProperty("resultCount"), XurrentField(IsDefaultQueryProperty = true)]
        public long? ResultCount { get; internal set; }

        /// <summary>
        /// Expiring link to the JSON result of the async query. It is available once the async query execution has been completed.
        /// </summary>
        [JsonProperty("resultUrl"), XurrentField(IsDefaultQueryProperty = true)]
        public string? ResultUrl { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was set to status <c>in_progress</c>.
        /// </summary>
        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// <br>The current status of the async query. Valid values are:</br>
        /// <br>• <c>queued</c>: The async query has been received and is waiting to be executed.</br>
        /// <br>• <c>in_progress</c>: The async query is being executed.</br>
        /// <br>• <c>completed</c>: The async query execution has been completed. Results can be found by downloading the <c>result_url</c>.</br>
        /// </summary>
        [JsonProperty("status"), XurrentField(IsDefaultQueryProperty = true)]
        public AsyncQueryStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
