using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projecttasktemplateupdatepayload/">ProjectTaskTemplateUpdatePayload</see> object.
    /// </summary>
    public class ProjectTaskTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTaskTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectTaskTemplate? ProjectTaskTemplate { get; internal set; }
    }
}
