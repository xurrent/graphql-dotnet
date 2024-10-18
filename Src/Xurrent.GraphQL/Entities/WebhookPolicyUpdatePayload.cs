using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/webhookpolicyupdatepayload/">WebhookPolicyUpdatePayload</see> object.
    /// </summary>
    public class WebhookPolicyUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhookPolicy"), XurrentField(IsDefaultQueryProperty = true)]
        public WebhookPolicy? WebhookPolicy { get; internal set; }
    }
}
