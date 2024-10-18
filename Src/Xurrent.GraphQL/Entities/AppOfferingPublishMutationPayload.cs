using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/appofferingpublishmutationpayload/">AppOfferingPublishMutationPayload</see> object.
    /// </summary>
    public class AppOfferingPublishMutationPayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOffering"), XurrentField(IsDefaultQueryProperty = true)]
        public AppOffering? AppOffering { get; internal set; }
    }
}
