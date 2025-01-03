﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Xurrent.GraphQL.Tests
{
    [TestClass]
    public class NoteTest
    {
        private readonly XurrentClient client = Client.Get();

        [TestMethod]
        public void AddNoteAndNoteReaction()
        {
            NoteCreatePayload noteCreatePayload = client.Mutation(new($"{DateTime.Now:HH:mm:ss.fff} - Hello World !!!")
            {
                Internal = true,
                OwnerId = "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9SZXEvNzA1MzE"
            }, new NoteQuery().Select(NoteField.ID).SelectNoteReactions(new NoteReactionQuery())).Result;

            Assert.IsNotNull(noteCreatePayload);
            Assert.IsNotNull(noteCreatePayload.Note);
            Assert.IsNotNull(noteCreatePayload.Note.NoteReactions);
            Assert.IsFalse(noteCreatePayload.IsError());

            NoteReactionCreatePayload noteReactionCreatePayload = client.Mutation(new NoteReactionCreateInput(noteCreatePayload.Note.ID, "👍"), new NoteReactionQuery().SelectAll()).Result;
            Assert.IsNotNull(noteReactionCreatePayload);
            Assert.IsNotNull(noteReactionCreatePayload.NoteReaction);
            Assert.IsNotNull(noteReactionCreatePayload.NoteReaction.Note);

            NoteReactionDeleteMutationPayload noteReactionDeleteMutationPayload = client.Mutation(new NoteReactionDeleteMutationInput(noteReactionCreatePayload.NoteReaction.ID)).Result;
            Assert.IsNotNull(noteReactionDeleteMutationPayload);
        }
    }
}
