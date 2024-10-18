using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Deletes a webhook.
    /// </summary>
    internal sealed class WebhookDeleteMutation : Mutation<WebhookDeleteMutationPayload, WebhookDeleteMutationInput>
    {
        /// <summary>
        /// Initialize an new WebhookDelete mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        internal WebhookDeleteMutation(WebhookDeleteMutationInput data)
            : base("webhookDelete", "WebhookDeleteMutationInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
