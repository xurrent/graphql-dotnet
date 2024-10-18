using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projectupdatepayload/">ProjectUpdatePayload</see> object.
    /// </summary>
    public class ProjectUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("project"), XurrentField(IsDefaultQueryProperty = true)]
        public Project? Project { get; internal set; }
    }
}
