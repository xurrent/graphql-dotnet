using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/agileboardcreatepayload/">AgileBoardCreatePayload</see> object.
    /// </summary>
    public class AgileBoardCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("agileBoard"), XurrentField(IsDefaultQueryProperty = true)]
        public AgileBoard? AgileBoard { get; internal set; }
    }
}
