using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// A Xurrent GraphQL response page info object.
    /// </summary>
    internal sealed class PageInfo
    {
        /// <summary>
        /// Gets or sets the response end cursor of this page.
        /// </summary>
        [JsonProperty("endCursor")]
        internal string EndCursor { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets if the response has a next page.
        /// </summary>
        [JsonProperty("hasNextPage")]
        internal bool HasNextPage { get; set; } = false;
    }
}
