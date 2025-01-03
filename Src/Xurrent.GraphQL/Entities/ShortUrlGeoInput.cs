﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/shorturlgeoinput/">ShortUrlGeoInput</see> object.
    /// </summary>
    public class ShortUrlGeoInput : PropertyChangeSet
    {
        private string latitude;
        private string longitude;

        /// <summary>
        /// Latitude coordinate of the location.
        /// </summary>
        [JsonProperty("latitude"), XurrentField(IsRequiredForMutation = true)]
        public string Latitude
        {
            get => latitude;
            set => latitude = Set("latitude", value);
        }

        /// <summary>
        /// Longitude coordinate of the location.
        /// </summary>
        [JsonProperty("longitude"), XurrentField(IsRequiredForMutation = true)]
        public string Longitude
        {
            get => longitude;
            set => longitude = Set("longitude", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlGeoInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlGeoInput()
        {
            latitude = string.Empty;
            longitude = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlGeoInput"/> class.
        /// </summary>
        /// <param name="latitude">Latitude coordinate of the location.</param>
        /// <param name="longitude">Longitude coordinate of the location.</param>
        public ShortUrlGeoInput(string latitude, string longitude)
        {
            this.latitude = Set("latitude", latitude);
            this.longitude = Set("longitude", longitude);
        }
    }
}
