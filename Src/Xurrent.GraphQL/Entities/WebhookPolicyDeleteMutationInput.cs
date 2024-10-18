using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/webhookpolicydeletemutationinput/">WebhookPolicyDeleteMutationInput</see> object.
    /// </summary>
    public class WebhookPolicyDeleteMutationInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string id;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The node ID of the record to delete.
        /// </summary>
        [JsonProperty("id"), XurrentField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyDeleteMutationInput"/> class without providing the required values.
        /// </summary>
        public WebhookPolicyDeleteMutationInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyDeleteMutationInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to delete.</param>
        public WebhookPolicyDeleteMutationInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
