using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/attachment/">Attachment</see> object.
    /// </summary>
    public class Attachment : Node
    {
        /// <summary>
        /// A temporary expiring URL that can be used to access the attachment.
        /// </summary>
        [JsonProperty("expiringUrl"), XurrentField(IsDefaultQueryProperty = true)]
        public string? ExpiringUrl { get; internal set; }

        /// <summary>
        /// The name of the attachment.
        /// </summary>
        [JsonProperty("filename"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Filename { get; internal set; }

        /// <summary>
        /// Whether the attachment is an inline image.
        /// </summary>
        [JsonProperty("inline"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Inline { get; internal set; }

        /// <summary>
        /// Key of the attachment that can be used to match the attachment to an inline image included in a rich text field.
        /// </summary>
        [JsonProperty("key"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Key { get; internal set; }

        /// <summary>
        /// The size of the attachment in bytes.
        /// </summary>
        [JsonProperty("size"), XurrentField(IsDefaultQueryProperty = true)]
        public long? Size { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
