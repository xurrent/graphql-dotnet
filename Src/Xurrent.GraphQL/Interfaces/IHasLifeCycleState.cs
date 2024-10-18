namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/interface/haslifecyclestate/">HasLifeCycleState</see> interface.
    /// </summary>
    public interface IHasLifeCycleState
    {
        /// <summary>
        /// Current state of the record.
        /// </summary>
        public LifeCycleState? LifeCycleState { get; }
    }
}
