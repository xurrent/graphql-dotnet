using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/personcreatepayload/">PersonCreatePayload</see> object.
    /// </summary>
    public class PersonCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("person"), XurrentField(IsDefaultQueryProperty = true)]
        public Person? Person { get; internal set; }
    }
}
