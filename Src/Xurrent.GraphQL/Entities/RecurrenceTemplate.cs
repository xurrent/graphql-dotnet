﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/recurrencetemplate/">RecurrenceTemplate</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class RecurrenceTemplate : Node
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
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        [JsonProperty("calendar"), XurrentField(IsDefaultQueryProperty = true)]
        public Calendar? Calendar { get; internal set; }

        /// <summary>
        /// <br><em>Required</em> when <c>frequency</c> is <c>daily</c>, ignored in all other cases. List of days of the week, e.g. <c>1,2,3,4,5</c>.</br>
        /// <br>• <c>0</c>: Sunday</br>
        /// <br>• <c>1</c>: Monday</br>
        /// <br>• <c>2</c>: Tuesday</br>
        /// <br>• <c>3</c>: Wednesday</br>
        /// <br>• <c>4</c>: Thursday</br>
        /// <br>• <c>5</c>: Friday</br>
        /// <br>• <c>6</c>: Saturday</br>
        /// </summary>
        [JsonProperty("day"), XurrentField(IsDefaultQueryProperty = true)]
        public List<long>? Day { get; internal set; }

        /// <summary>
        /// <br><em>Required</em> when <c>frequency</c> is <c>monthly</c> and <c>day_of_week</c> is <c>false</c>, ignored in all other cases. List of days of the month, e.g. <c>11,21,-1</c>.</br>
        /// <br>• <c>1</c>: Day one</br>
        /// <br>• <c>2</c>: Day two</br>
        /// <br>• <c>3</c>: Day three</br>
        /// <br>• ...</br>
        /// <br>• <c>30</c>: Day thirty</br>
        /// <br>• <c>31</c>: Day thirty-one</br>
        /// <br>• <c>-1</c>: Last day of month</br>
        /// </summary>
        [JsonProperty("dayOfMonth"), XurrentField(IsDefaultQueryProperty = true)]
        public List<long>? DayOfMonth { get; internal set; }

        /// <summary>
        /// Indicates whether or not the <c>dayOfWeekIndex</c> and <c>dayOfWeekDay</c> values should be considered. Can only be set to <c>true</c> when <c>frequency</c> is <c>monthly</c> or <c>yearly</c>.
        /// </summary>
        [JsonProperty("dayOfWeek"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? DayOfWeek { get; internal set; }

        /// <summary>
        /// <em>Required</em> when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [JsonProperty("dayOfWeekDay"), XurrentField(IsDefaultQueryProperty = true)]
        public DayNames? DayOfWeekDay { get; internal set; }

        /// <summary>
        /// <em>Required</em> when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [JsonProperty("dayOfWeekIndex"), XurrentField(IsDefaultQueryProperty = true)]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex { get; internal set; }

        /// <summary>
        /// Whether recurrency should be temporarily disabled.
        /// </summary>
        [JsonProperty("disabled"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The frequency of the recurrency.
        /// </summary>
        [JsonProperty("frequency"), XurrentField(IsDefaultQueryProperty = true)]
        public RecurrenceFrequency? Frequency { get; internal set; }

        /// <summary>
        /// The interval of the Frequency, e.g. every 2nd week or every 10th day.
        /// </summary>
        [JsonProperty("interval"), XurrentField(IsDefaultQueryProperty = true)]
        public long? Interval { get; internal set; }

        /// <summary>
        /// <br><em>Required</em> when <c>frequency</c> is <c>yearly</c>, ignored in all other cases. List of months of the year, e.g. <c>3,6,9,12</c>.</br>
        /// <br>• <c>1</c>: January</br>
        /// <br>• <c>2</c>: February</br>
        /// <br>• <c>3</c>: March</br>
        /// <br>• <c>4</c>: April</br>
        /// <br>• <c>5</c>: May</br>
        /// <br>• <c>6</c>: June</br>
        /// <br>• <c>7</c>: July</br>
        /// <br>• <c>8</c>: August</br>
        /// <br>• <c>9</c>: September</br>
        /// <br>• <c>10</c>: October</br>
        /// <br>• <c>11</c>: November</br>
        /// <br>• <c>12</c>: December</br>
        /// </summary>
        [JsonProperty("monthOfYear"), XurrentField(IsDefaultQueryProperty = true)]
        public List<long>? MonthOfYear { get; internal set; }

        /// <summary>
        /// The time of day to start the scheduled occurrence.
        /// </summary>
        [JsonProperty("timeOfDay"), XurrentField(IsDefaultQueryProperty = true)]
        public TimeSpan? TimeOfDay { get; internal set; }

        /// <summary>
        /// <br>The time zone for the <c>timeOfDay</c> field.</br>
        /// <br>The complete list is available on the <see href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone"), XurrentField(IsDefaultQueryProperty = true)]
        public string? TimeZone { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
