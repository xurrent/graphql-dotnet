using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/sprintbacklogitem/">SprintBacklogItem</see> object.
    /// </summary>
    public class SprintBacklogItem : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether this item has been completed in this sprint. <c>null</c> indicates the item was removed from the sprint.
        /// </summary>
        [JsonProperty("done")]
        public bool? Done { get; internal set; }

        /// <summary>
        /// Estimate of the relative size of this record on the sprint backlog.
        /// </summary>
        [JsonProperty("estimate")]
        public long? Estimate { get; internal set; }

        /// <summary>
        /// Whether this item was part of the sprint backlog when the sprint was started.
        /// </summary>
        [JsonProperty("planned")]
        public bool? Planned { get; internal set; }

        /// <summary>
        /// Position of this record on the sprint backlog.
        /// </summary>
        [JsonProperty("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Record on the sprint backlog.
        /// </summary>
        [JsonProperty("record")]
        public IHasSprintBacklogItems? Record { get; internal set; }

        /// <summary>
        /// Sprint this record is part of.
        /// </summary>
        [JsonProperty("sprint")]
        public Sprint? Sprint { get; internal set; }

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
