﻿using Newtonsoft.Json;
using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// A log message.
    /// </summary>
    public class TraceMessage
    {
        private static readonly JsonSerializerSettings jsonSerializerSettings = new() { Formatting = Formatting.None, NullValueHandling = NullValueHandling.Ignore };

        /// <summary>
        /// Gets or sets the HTTP method.
        /// </summary>
        [JsonProperty("id")]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method.
        /// </summary>
        [JsonProperty("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request URI.
        /// </summary>
        [JsonProperty("uri")]
        public string? URI { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request content.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Gets or sets the Xurrent account identifier.
        /// </summary>
        [JsonProperty("account_id")]
        public string? AccountID { get; set; }

        /// <summary>
        /// Gets or sets the request response time in milliseconds.
        /// </summary>
        [JsonProperty("response_time_in_ms")]
        public long? ResponseTimeInMilliseconds { get; set; }

        /// <summary>
        /// Returns a JSON formatted string that represents the object instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, jsonSerializerSettings);
        }
    }
}
