using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/problemcreatepayload/">ProblemCreatePayload</see> object.
    /// </summary>
    public class ProblemCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("problem"), XurrentField(IsDefaultQueryProperty = true)]
        public Problem? Problem { get; internal set; }
    }
}
