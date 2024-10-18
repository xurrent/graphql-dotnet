using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shorturl/">ShortUrl</see> object.
    /// </summary>
    public class ShortUrl : Node
    {
        /// <summary>
        /// Unique token that someone who uses the short URL for a dashboard is asked to enter.
        /// </summary>
        [JsonProperty("accessToken")]
        public string? AccessToken { get; internal set; }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Kind of URI the short URL forwards to.
        /// </summary>
        [JsonProperty("dataType"), XurrentField(IsDefaultQueryProperty = true)]
        public ShortUrlDataType? DataType { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The uniform resource identifier (URI) to which the short URL is forwarded.
        /// </summary>
        [JsonProperty("uri")]
        public string? Uri { get; internal set; }

        /// <summary>
        /// The automatically generated website address that is forwarded to URI.
        /// </summary>
        [JsonProperty("shortUrl"), XurrentField(IsDefaultQueryProperty = true)]
        public string? URL { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
