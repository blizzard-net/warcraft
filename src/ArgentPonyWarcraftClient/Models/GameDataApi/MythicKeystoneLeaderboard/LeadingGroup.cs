using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A leading group.
    /// </summary>
    public class LeadingGroup
    {
        /// <summary>
        /// Gets the ranking of the group.
        /// </summary>
        [JsonProperty("ranking")]
        public long Ranking { get; set; }

        /// <summary>
        /// Gets the duration of the run.
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// Gets the timestamp of the completion.
        /// </summary>
        [JsonProperty("completed_timestamp")]
        public DateTime CompletedTimestamp { get; set; }

        /// <summary>
        /// Gets the keystone level.
        /// </summary>
        [JsonProperty("keystone_level")]
        public long KeystoneLevel { get; set; }

        /// <summary>
        /// Gets the members of the group.
        /// </summary>
        [JsonProperty("members")]
        public Member[] Members { get; set; }
    }
}
