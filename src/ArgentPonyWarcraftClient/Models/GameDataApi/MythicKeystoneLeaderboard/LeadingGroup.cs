using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("ranking")]
        public int Ranking { get; set; }

        /// <summary>
        /// Gets the duration of the run.
        /// </summary>
        [JsonPropertyName("duration")]
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets the timestamp of the completion.
        /// </summary>
        [JsonPropertyName("completed_timestamp")]
        public DateTimeOffset CompletedTimestamp { get; set; }

        /// <summary>
        /// Gets the keystone level.
        /// </summary>
        [JsonPropertyName("keystone_level")]
        public int KeystoneLevel { get; set; }

        /// <summary>
        /// Gets the members of the group.
        /// </summary>
        [JsonPropertyName("members")]
        public Member[] Members { get; set; }
    }
}
