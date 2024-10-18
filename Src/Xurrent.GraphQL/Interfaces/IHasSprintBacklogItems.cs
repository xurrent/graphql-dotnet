namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/interface/hassprintbacklogitems/">HasSprintBacklogItems</see> interface.
    /// </summary>
    public interface IHasSprintBacklogItems
    {
        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public DataList<SprintBacklogItem>? SprintBacklogItems { get; }
    }
}
