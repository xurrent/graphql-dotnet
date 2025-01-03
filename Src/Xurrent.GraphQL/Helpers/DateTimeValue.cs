using System;

namespace Xurrent.GraphQL.Helpers
{
    /// <summary>
    /// A set of Xurrent specific date time values.
    /// </summary>
    public static class DateTimeValue
    {
        /// <summary>
        /// The Xurrent SDK predefined 'best effort' date time value.
        /// </summary>
        public static readonly DateTime BestEffortDateTime = new(1, 1, 1, 1, 1, 1, 111);

        /// <summary>
        /// The Xurrent SDK predefined 'no target' date time value.
        /// </summary>
        public static readonly DateTime NoTargetDateTime = new(2, 2, 2, 2, 2, 2, 222);

        /// <summary>
        /// The Xurrent SDK predefined 'clock stopped' date time value.
        /// </summary>
        public static readonly DateTime ClockStoppedDateTime = new(3, 3, 3, 3, 3, 3, 333);

        /// <summary>
        /// The Xurrent 'best effort' string value.
        /// </summary>
        public const string BestEffortText = "best_effort";

        /// <summary>
        /// The Xurrent 'no target' string value.
        /// </summary>
        public const string NoTargetText = "no_target";

        /// <summary>
        /// The Xurrent 'clocked stopped' string value.
        /// </summary>
        public const string ClockStoppedText = "clock_stopped";
    }
}
