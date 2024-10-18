using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/slanotificationscheme/">SlaNotificationScheme</see> object.
    /// </summary>
    public class SlaNotificationScheme : Node
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
        /// Whether the SLA notification scheme may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The name of the SLA notification scheme.
        /// </summary>
        [JsonProperty("name"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        [JsonProperty("slaNotificationRules")]
        internal NodeCollection<SlaNotificationRule>? SlaNotificationRulesCollection { get; set; }

        /// <summary>
        /// Rules of the SLA notification scheme.
        /// </summary>
        public DataList<SlaNotificationRule>? SlaNotificationRules
        {
            get => SlaNotificationRulesCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), XurrentField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(SlaNotificationRulesCollection?.GetQueryPageInfo("slaNotificationRules", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            SlaNotificationRules?.AddRange((data as SlaNotificationScheme)?.SlaNotificationRules);
        }
    }
}
