using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/agileboardupdatepayload/">AgileBoardUpdatePayload</see> object.
    /// </summary>
    public class AgileBoardUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("agileBoard"), XurrentField(IsDefaultQueryProperty = true)]
        public AgileBoard? AgileBoard { get; internal set; }
    }
}
