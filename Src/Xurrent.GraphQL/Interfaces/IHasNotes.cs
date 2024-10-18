namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/interface/hasnotes/">HasNotes</see> interface.
    /// </summary>
    public interface IHasNotes
    {
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public DataList<Note>? Notes { get; }
    }
}
