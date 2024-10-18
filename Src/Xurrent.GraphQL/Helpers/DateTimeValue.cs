using System;

namespace Xurrent.GraphQL.Helpers
{
    /// <summary>
    /// A set of Xurrent specific date time values.
    /// </summary>
    public static class DateTimeValue
    {
        private static readonly DateTime bestEffort = new(1, 1, 1, 1, 1, 1, 111);
        private static readonly DateTime noTarget = new(2, 2, 2, 2, 2, 2, 222);
        private static readonly DateTime clockStopped = new(3, 3, 3, 3, 3, 3, 333);

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

        /// <summary>
        /// The Xurrent SDK predefined 'best effort' date time value.
        /// </summary>
        public static DateTime BestEffortDateTime => bestEffort;

        /// <summary>
        /// The Xurrent SDK predefined 'no target' date time value.
        /// </summary>
        public static DateTime NoTargetDateTime => noTarget;

        /// <summary>
        /// The Xurrent SDK predefined 'clock stopped' date time value.
        /// </summary>
        public static DateTime ClockStoppedDateTime => clockStopped;
    }
}
