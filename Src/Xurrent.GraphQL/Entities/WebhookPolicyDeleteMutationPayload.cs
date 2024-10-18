using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/webhookpolicydeletemutationpayload/">WebhookPolicyDeleteMutationPayload</see> object.
    /// </summary>
    public class WebhookPolicyDeleteMutationPayload : Payload
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("success"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
