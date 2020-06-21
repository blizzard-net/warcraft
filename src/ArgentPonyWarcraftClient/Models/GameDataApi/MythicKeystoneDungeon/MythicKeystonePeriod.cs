using System;
using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone period.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the start timestampe of the mythic keystone period.
        /// </summary>
        [JsonProperty("start_timestamp")]
        public DateTime StartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestampe of the mythic keystone period.
        /// </summary>
        [JsonProperty("end_timestamp")]
        public DateTime EndTimestamp { get; set; }
    }
}
