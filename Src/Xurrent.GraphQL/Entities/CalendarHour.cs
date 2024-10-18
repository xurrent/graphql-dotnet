using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/calendarhour/">CalendarHour</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class CalendarHour : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => (Weekday is not null && TimeFrom is not null && TimeUntil is not null) ? $"{Weekday?.ToString()}, {Math.Floor(TimeFrom?.TotalHours ?? 0):00}:{TimeFrom?.Minutes:00} - {Math.Floor(TimeUntil?.TotalHours ?? 0):00}:{TimeUntil?.Minutes:00}" : ToString();
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
        /// The time at which the calendar becomes active on the given weekday.
        /// </summary>
        [JsonProperty("timeFrom"), XurrentField(IsDefaultQueryProperty = true)]
        public TimeSpan? TimeFrom { get; internal set; }

        /// <summary>
        /// The time at which the calendar stops being active on the given weekday.
        /// </summary>
        [JsonProperty("timeUntil"), XurrentField(IsDefaultQueryProperty = true)]
        public TimeSpan? TimeUntil { get; internal set; }

        /// <summary>
        /// The day of the week.
        /// </summary>
        [JsonProperty("weekday"), XurrentField(IsDefaultQueryProperty = true)]
        public Weekday? Weekday { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
