using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/serviceinstanceupdatepayload/">ServiceInstanceUpdatePayload</see> object.
    /// </summary>
    public class ServiceInstanceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceInstance"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceInstance? ServiceInstance { get; internal set; }
    }
}
