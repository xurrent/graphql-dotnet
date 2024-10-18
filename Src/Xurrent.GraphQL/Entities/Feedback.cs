using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/feedback/">Feedback</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class Feedback : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URLs to capture feedback from the person who submitted the request.
        /// </summary>
        [JsonProperty("requestedBy"), XurrentField(IsDefaultQueryProperty = true)]
        public FeedbackUrls? RequestedBy { get; internal set; }

        /// <summary>
        /// URLs to capture feedback from the person for whom the request was submitted, if that was not the submitter of the request.
        /// </summary>
        [JsonProperty("requestedFor"), XurrentField(IsDefaultQueryProperty = true)]
        public FeedbackUrls? RequestedFor { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
