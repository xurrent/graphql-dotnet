using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/workflowtypecreatepayload/">WorkflowTypeCreatePayload</see> object.
    /// </summary>
    public class WorkflowTypeCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflowType"), XurrentField(IsDefaultQueryProperty = true)]
        public WorkflowType? WorkflowType { get; internal set; }
    }
}
