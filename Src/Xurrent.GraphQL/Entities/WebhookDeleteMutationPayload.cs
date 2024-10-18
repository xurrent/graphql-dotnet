using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/webhookdeletemutationpayload/">WebhookDeleteMutationPayload</see> object.
    /// </summary>
    public class WebhookDeleteMutationPayload : Payload
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("success"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
