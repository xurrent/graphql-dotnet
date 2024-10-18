﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/reservationupdatepayload/">ReservationUpdatePayload</see> object.
    /// </summary>
    public class ReservationUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservation"), XurrentField(IsDefaultQueryProperty = true)]
        public Reservation? Reservation { get; internal set; }
    }
}
