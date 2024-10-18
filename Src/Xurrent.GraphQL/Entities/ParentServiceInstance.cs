using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/parentserviceinstance/">ParentServiceInstance</see> object.
    /// </summary>
    public class ParentServiceInstance : Node
    {
        /// <summary>
        /// Indication of whether the consuming service instance is down or degraded when the service instance of the service level agreement is down or degraded.
        /// </summary>
        [JsonProperty("impactRelation"), XurrentField(IsDefaultQueryProperty = true)]
        public ParentServiceInstanceImpactRelation? ImpactRelation { get; internal set; }

        /// <summary>
        /// Service instance consuming the service instance of the service level agreement.
        /// </summary>
        [JsonProperty("serviceInstance"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceInstance? ServiceInstance { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
