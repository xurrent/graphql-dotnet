﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/note/">Note</see> object.
    /// </summary>
    public class Note : Node
    {
        /// <summary>
        /// The account.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the note was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The inbound email from which the note was created.
        /// </summary>
        [JsonProperty("inboundEmail")]
        public InboundEmail? InboundEmail { get; internal set; }

        /// <summary>
        /// Whether the notes is internal or not.
        /// </summary>
        [JsonProperty("internal"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Internal { get; internal set; }

        /// <summary>
        /// <br>The medium used to add the note. Valid values are:</br>
        /// <br>• <c>default</c>: the note was manually added by a person, or automatically using the REST, Import or GraphQL API.</br>
        /// <br>• <c>email</c>: the note was added by the Mail API</br>
        /// <br>• <c>outbound_email</c>: the note was created via the "Send Email" action</br>
        /// <br>• <c>system</c>: the note was generated by the system</br>
        /// <br>• <c>redacted</c>: the note was deleted by an account administrator</br>
        /// <br>• <c>automation</c>: the note was added by an automation rule</br>
        /// </summary>
        [JsonProperty("medium"), XurrentField(IsDefaultQueryProperty = true)]
        public NoteMedium? Medium { get; internal set; }

        [JsonProperty("noteReactions")]
        internal NodeCollection<NoteReaction>? NoteReactionsCollection { get; set; }

        /// <summary>
        /// The note reactions belonging to this note.
        /// </summary>
        public DataList<NoteReaction>? NoteReactions
        {
            get => NoteReactionsCollection?.Data;
        }

        /// <summary>
        /// Person who added this note.
        /// </summary>
        [JsonProperty("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// Text of this note.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }

        [JsonProperty("textAttachments")]
        internal NodeCollection<Attachment>? TextAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        public DataList<Attachment>? TextAttachments
        {
            get => TextAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Visibility of this note.
        /// </summary>
        [JsonProperty("visibility")]
        public NoteVisibility? Visibility { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(NoteReactionsCollection?.GetQueryPageInfo("noteReactions", depth + 1));
            retval.AddRange(TextAttachmentsCollection?.GetQueryPageInfo("textAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            NoteReactions?.AddRange((data as Note)?.NoteReactions);
            TextAttachments?.AddRange((data as Note)?.TextAttachments);
        }
    }
}