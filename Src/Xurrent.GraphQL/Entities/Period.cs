using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/period/">Period</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class Period : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => (From is not null && To is not null) ? $"{From:yyyy=MM-dd HH:mm:ss} - {To:yyyy=MM-dd HH:mm:ss}" : ToString();
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
        /// Start of the period
        /// </summary>
        [JsonProperty("from"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? From { get; internal set; }

        /// <summary>
        /// Provider Not Accountable
        /// </summary>
        [JsonProperty("providerNotAccountable"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// End of the period
        /// </summary>
        [JsonProperty("to"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? To { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
