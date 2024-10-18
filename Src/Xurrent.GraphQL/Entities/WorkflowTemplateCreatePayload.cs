using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/workflowtemplatecreatepayload/">WorkflowTemplateCreatePayload</see> object.
    /// </summary>
    public class WorkflowTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflowTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }
    }
}
