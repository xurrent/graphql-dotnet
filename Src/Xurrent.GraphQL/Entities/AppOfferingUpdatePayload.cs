using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/appofferingupdatepayload/">AppOfferingUpdatePayload</see> object.
    /// </summary>
    public class AppOfferingUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOffering"), XurrentField(IsDefaultQueryProperty = true)]
        public AppOffering? AppOffering { get; internal set; }
    }
}
