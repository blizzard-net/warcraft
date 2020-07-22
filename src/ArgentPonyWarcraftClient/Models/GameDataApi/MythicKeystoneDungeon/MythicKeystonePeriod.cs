using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone period.
    /// </summary>
    public class MythicKeystonePeriod
    {
        /// <summary>
        /// Gets links for the mythic keystone period.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone period.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the start timestampe of the mythic keystone period.
        /// </summary>
        [JsonPropertyName("start_timestamp")]
        public DateTime StartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestampe of the mythic keystone period.
        /// </summary>
        [JsonPropertyName("end_timestamp")]
        public DateTime EndTimestamp { get; set; }
    }
}
