using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/workflowupdatepayload/">WorkflowUpdatePayload</see> object.
    /// </summary>
    public class WorkflowUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflow"), XurrentField(IsDefaultQueryProperty = true)]
        public Workflow? Workflow { get; internal set; }
    }
}
