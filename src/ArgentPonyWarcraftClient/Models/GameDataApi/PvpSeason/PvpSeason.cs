using System;
using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the PvP season.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a link to PvP leaderboards.
        /// </summary>
        [JsonProperty("leaderboards")]
        public Self Leaderboards { get; set; }

        /// <summary>
        /// Gets a link to PvP rewards.
        /// </summary>
        [JsonProperty("rewards")]
        public Self Rewards { get; set; }

        /// <summary>
        /// Gets the start timestamp of the PvP season.
        /// </summary>
        [JsonProperty("season_start_timestamp")]
        public DateTime SeasonStartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestamp of the PvP season.
        /// </summary>
        [JsonProperty("season_end_timestamp")]
        public DateTime SeasonEndTimestamp { get; set; }
    }
}
