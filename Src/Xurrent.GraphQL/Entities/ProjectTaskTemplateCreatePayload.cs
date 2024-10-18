using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projecttasktemplatecreatepayload/">ProjectTaskTemplateCreatePayload</see> object.
    /// </summary>
    public class ProjectTaskTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTaskTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectTaskTemplate? ProjectTaskTemplate { get; internal set; }
    }
}
