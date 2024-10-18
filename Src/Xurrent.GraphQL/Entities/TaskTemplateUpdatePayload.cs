using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/tasktemplateupdatepayload/">TaskTemplateUpdatePayload</see> object.
    /// </summary>
    public class TaskTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("taskTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public TaskTemplate? TaskTemplate { get; internal set; }
    }
}
