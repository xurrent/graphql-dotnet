using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/requesttemplateupdatepayload/">RequestTemplateUpdatePayload</see> object.
    /// </summary>
    public class RequestTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("requestTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public RequestTemplate? RequestTemplate { get; internal set; }
    }
}
