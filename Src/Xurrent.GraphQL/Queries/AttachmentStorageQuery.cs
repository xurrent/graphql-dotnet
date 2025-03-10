﻿namespace Xurrent.GraphQL
{
    /// <summary>
    /// Details on how to upload files to the Xurrent attachment storage facility.
    /// </summary>
    public class AttachmentStorageQuery : Query<AttachmentStorageQuery, AttachmentStorageField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new attachment storage query instance.
        /// </summary>
        public AttachmentStorageQuery()
            : base("attachmentStorage", typeof(AttachmentStorage), false)
        {
        }
    }
}
