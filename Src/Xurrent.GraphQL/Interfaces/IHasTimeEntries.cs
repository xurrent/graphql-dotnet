namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/interface/hastimeentries/">HasTimeEntries</see> interface.
    /// </summary>
    public interface IHasTimeEntries
    {
        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public DataList<TimeEntry>? TimeEntries { get; }
    }
}
