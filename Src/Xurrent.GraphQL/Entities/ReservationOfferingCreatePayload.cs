using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/reservationofferingcreatepayload/">ReservationOfferingCreatePayload</see> object.
    /// </summary>
    public class ReservationOfferingCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("reservationOffering"), XurrentField(IsDefaultQueryProperty = true)]
        public ReservationOffering? ReservationOffering { get; internal set; }
    }
}
