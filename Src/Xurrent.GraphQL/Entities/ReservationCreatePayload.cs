using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/reservationcreatepayload/">ReservationCreatePayload</see> object.
    /// </summary>
    public class ReservationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservation"), XurrentField(IsDefaultQueryProperty = true)]
        public Reservation? Reservation { get; internal set; }
    }
}
