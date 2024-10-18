using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/snapshot/">Snapshot</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class Snapshot : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => DownloadUrl ?? ToString();
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
        /// Expiring link to the snapshot content.
        /// </summary>
        [JsonProperty("downloadUrl"), XurrentField(IsDefaultQueryProperty = true)]
        public string? DownloadUrl { get; internal set; }

        /// <summary>
        /// Time at which snapshot was taken.
        /// </summary>
        [JsonProperty("startedAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? StartedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
