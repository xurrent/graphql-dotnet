using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/invoiceupdatepayload/">InvoiceUpdatePayload</see> object.
    /// </summary>
    public class InvoiceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("invoice"), XurrentField(IsDefaultQueryProperty = true)]
        public Invoice? Invoice { get; internal set; }
    }
}
