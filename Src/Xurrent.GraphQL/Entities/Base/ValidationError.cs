using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Errors encountered during the mutation.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    [DebuggerDisplay("{Message}")]
    public class ValidationError : Node
    {
        /// <summary>
        /// A description of the error.
        /// </summary>
        [JsonProperty("message"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Message { get; set; }

        /// <summary>
        /// Which input value this error came from.
        /// </summary>
        [JsonProperty("path"), XurrentField(IsDefaultQueryProperty = true)]
        public List<string>? Path { get; set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
