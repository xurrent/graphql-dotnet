using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/workflowcreatepayload/">WorkflowCreatePayload</see> object.
    /// </summary>
    public class WorkflowCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflow"), XurrentField(IsDefaultQueryProperty = true)]
        public Workflow? Workflow { get; internal set; }
    }
}
