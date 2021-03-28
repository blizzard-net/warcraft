using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP season.
    /// </summary>
    public class PvpSeason
    {
        /// <summary>
        /// Gets links for the PvP season.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the PvP season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a link to PvP leaderboards.
        /// </summary>
        [JsonPropertyName("leaderboards")]
        public Self Leaderboards { get; set; }

        /// <summary>
        /// Gets a link to PvP rewards.
        /// </summary>
        [JsonPropertyName("rewards")]
        public Self Rewards { get; set; }

        /// <summary>
        /// Gets the start timestamp of the PvP season.
        /// </summary>
        [JsonPropertyName("season_start_timestamp")]
        public DateTimeOffset SeasonStartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestamp of the PvP season.
        /// </summary>
        [JsonPropertyName("season_end_timestamp")]
        public DateTimeOffset SeasonEndTimestamp { get; set; }
    }
}
