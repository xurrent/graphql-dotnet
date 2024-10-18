using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/automationruleaction/">AutomationRuleAction</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class AutomationRuleAction : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => Name ?? ToString();
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
        /// Name of the action.
        /// </summary>
        [JsonProperty("name"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The action that should be executed when the condition of the automation rule is met.
        /// </summary>
        [JsonProperty("value"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Value { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
