using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projecttemplateupdatepayload/">ProjectTemplateUpdatePayload</see> object.
    /// </summary>
    public class ProjectTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectTemplate? ProjectTemplate { get; internal set; }
    }
}
