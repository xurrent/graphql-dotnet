using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/standardservicerequestactivityid/">StandardServiceRequestActivityID</see> object.
    /// </summary>
    public class StandardServiceRequestActivityID : Node
    {
        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("activityID")]
        public string? ActivityID { get; internal set; }

        /// <summary>
        /// The date and time at which the activityID was created.
        /// </summary>
        [JsonProperty("createdAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The standard service request for which an activityID is provided.
        /// </summary>
        [JsonProperty("standardServiceRequest")]
        public StandardServiceRequest? StandardServiceRequest { get; internal set; }

        /// <summary>
        /// The date and time at which the activityID was updated.
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
