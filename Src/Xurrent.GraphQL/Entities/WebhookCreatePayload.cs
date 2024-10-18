using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/webhookcreatepayload/">WebhookCreatePayload</see> object.
    /// </summary>
    public class WebhookCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhook"), XurrentField(IsDefaultQueryProperty = true)]
        public Webhook? Webhook { get; internal set; }
    }
}
