using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/requestupdatepayload/">RequestUpdatePayload</see> object.
    /// </summary>
    public class RequestUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("request"), XurrentField(IsDefaultQueryProperty = true)]
        public Request? Request { get; internal set; }
    }
}
