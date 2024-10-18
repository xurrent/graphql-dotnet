using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerfollowupupdatepayload/">WaitingForCustomerFollowUpUpdatePayload</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("waitingForCustomerFollowUp"), XurrentField(IsDefaultQueryProperty = true)]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }
    }
}
