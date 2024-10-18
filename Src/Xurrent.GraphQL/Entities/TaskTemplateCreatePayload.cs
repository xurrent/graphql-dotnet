using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/tasktemplatecreatepayload/">TaskTemplateCreatePayload</see> object.
    /// </summary>
    public class TaskTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("taskTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public TaskTemplate? TaskTemplate { get; internal set; }
    }
}
