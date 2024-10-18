using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Deletes a note reaction from a note.
    /// </summary>
    internal sealed class NoteReactionDeleteMutation : Mutation<NoteReactionDeleteMutationPayload, NoteReactionDeleteMutationInput>
    {
        /// <summary>
        /// Initialize an new NoteReactionDelete mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        internal NoteReactionDeleteMutation(NoteReactionDeleteMutationInput data)
            : base("noteReactionDelete", "NoteReactionDeleteMutationInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
