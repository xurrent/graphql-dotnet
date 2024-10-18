namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/interface/hastranslations/">HasTranslations</see> interface.
    /// </summary>
    public interface IHasTranslations
    {
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations { get; }
    }
}
