using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projecttaskcreatepayload/">ProjectTaskCreatePayload</see> object.
    /// </summary>
    public class ProjectTaskCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTask"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectTask? ProjectTask { get; internal set; }
    }
}
