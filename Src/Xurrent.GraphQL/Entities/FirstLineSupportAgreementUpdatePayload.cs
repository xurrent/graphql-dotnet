using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/firstlinesupportagreementupdatepayload/">FirstLineSupportAgreementUpdatePayload</see> object.
    /// </summary>
    public class FirstLineSupportAgreementUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("firstLineSupportAgreement"), XurrentField(IsDefaultQueryProperty = true)]
        public FirstLineSupportAgreement? FirstLineSupportAgreement { get; internal set; }
    }
}
