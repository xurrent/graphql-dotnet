using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projecttemplatecreatepayload/">ProjectTemplateCreatePayload</see> object.
    /// </summary>
    public class ProjectTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectTemplate? ProjectTemplate { get; internal set; }
    }
}
