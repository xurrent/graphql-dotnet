using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/webhookpolicycreatepayload/">WebhookPolicyCreatePayload</see> object.
    /// </summary>
    public class WebhookPolicyCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhookPolicy"), XurrentField(IsDefaultQueryProperty = true)]
        public WebhookPolicyCreateResponse? WebhookPolicy { get; internal set; }
    }
}
