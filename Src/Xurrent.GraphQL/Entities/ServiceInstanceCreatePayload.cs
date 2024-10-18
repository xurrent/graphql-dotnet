using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/serviceinstancecreatepayload/">ServiceInstanceCreatePayload</see> object.
    /// </summary>
    public class ServiceInstanceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceInstance"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceInstance? ServiceInstance { get; internal set; }
    }
}
