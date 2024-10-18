using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/personupdatepayload/">PersonUpdatePayload</see> object.
    /// </summary>
    public class PersonUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("person"), XurrentField(IsDefaultQueryProperty = true)]
        public Person? Person { get; internal set; }
    }
}
