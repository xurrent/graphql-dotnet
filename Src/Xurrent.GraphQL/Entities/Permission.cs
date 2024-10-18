using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/permission/">Permission</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class Permission : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => Account?.ID ?? ToString();
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
        /// Account for which the person has permissions.
        /// </summary>
        [JsonProperty("account"), XurrentField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Roles the person has within the account.
        /// </summary>
        [JsonProperty("roles"), XurrentField(IsDefaultQueryProperty = true)]
        public List<PermissionRole>? Roles { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
