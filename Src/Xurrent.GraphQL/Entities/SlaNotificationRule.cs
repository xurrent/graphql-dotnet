using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/slanotificationrule/">SlaNotificationRule</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class SlaNotificationRule : Node
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
        /// Whether to notify the current assignee of the request.
        /// </summary>
        [JsonProperty("notifyCurrentAssignee"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? NotifyCurrentAssignee { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team coordinator of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamCoordinator"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? NotifyFirstLineTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team manager of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamManager"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? NotifyFirstLineTeamManager { get; internal set; }

        /// <summary>
        /// Whether to notify the service owner of the service of the affected SLA.
        /// </summary>
        [JsonProperty("notifyServiceOwner"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? NotifyServiceOwner { get; internal set; }

        /// <summary>
        /// Whether to notify the support team coordinator of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifySupportTeamCoordinator"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? NotifySupportTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the support team manager of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifySupportTeamManager"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? NotifySupportTeamManager { get; internal set; }

        /// <summary>
        /// The percentage of the target duration when a notification should be generated.
        /// </summary>
        [JsonProperty("thresholdPercentage"), XurrentField(IsDefaultQueryProperty = true)]
        public long? ThresholdPercentage { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
