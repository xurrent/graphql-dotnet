using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Deletes a webhook policy.
    /// </summary>
    internal sealed class WebhookPolicyDeleteMutation : Mutation<WebhookPolicyDeleteMutationPayload, WebhookPolicyDeleteMutationInput>
    {
        /// <summary>
        /// Initialize an new WebhookPolicyDelete mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        internal WebhookPolicyDeleteMutation(WebhookPolicyDeleteMutationInput data)
            : base("webhookPolicyDelete", "WebhookPolicyDeleteMutationInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
