using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerfollowupcreatepayload/">WaitingForCustomerFollowUpCreatePayload</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("waitingForCustomerFollowUp"), XurrentField(IsDefaultQueryProperty = true)]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }
    }
}
