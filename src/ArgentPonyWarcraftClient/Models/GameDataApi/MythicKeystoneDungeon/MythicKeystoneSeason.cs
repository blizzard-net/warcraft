using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone season.
    /// </summary>
    public class MythicKeystoneSeason
    {
        /// <summary>
        /// Gets links for the mythic keystone season.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the start timestamp of the mythic keystone season.
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public DateTime StartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestamp of the mythic keystone season.
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public DateTime EndTimestamp { get; set; }

        /// <summary>
        /// Gets refernces to the periods in the mythic keystone season.
        /// </summary>
        [JsonPropertyName("periods")]
        public MythicKeystonePeriodReference[] Periods { get; set; }
    }
}
