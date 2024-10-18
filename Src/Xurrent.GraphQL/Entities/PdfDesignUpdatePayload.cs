using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/pdfdesignupdatepayload/">PdfDesignUpdatePayload</see> object.
    /// </summary>
    public class PdfDesignUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("pdfDesign"), XurrentField(IsDefaultQueryProperty = true)]
        public PdfDesign? PdfDesign { get; internal set; }
    }
}
