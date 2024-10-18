using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/serviceofferingupdatepayload/">ServiceOfferingUpdatePayload</see> object.
    /// </summary>
    public class ServiceOfferingUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceOffering"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceOffering? ServiceOffering { get; internal set; }
    }
}
