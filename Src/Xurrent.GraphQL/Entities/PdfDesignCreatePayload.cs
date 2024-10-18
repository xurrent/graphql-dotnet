using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/pdfdesigncreatepayload/">PdfDesignCreatePayload</see> object.
    /// </summary>
    public class PdfDesignCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("pdfDesign"), XurrentField(IsDefaultQueryProperty = true)]
        public PdfDesign? PdfDesign { get; internal set; }
    }
}
