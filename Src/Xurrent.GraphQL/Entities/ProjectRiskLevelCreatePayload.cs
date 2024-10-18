using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projectrisklevelcreatepayload/">ProjectRiskLevelCreatePayload</see> object.
    /// </summary>
    public class ProjectRiskLevelCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectRiskLevel"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectRiskLevel? ProjectRiskLevel { get; internal set; }
    }
}
