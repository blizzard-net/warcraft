using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP season.
    /// </summary>
    public record PvpSeason
    {
        /// <summary>
        /// Gets links for the PvP season.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the PvP season.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a link to PvP leaderboards.
        /// </summary>
        [JsonPropertyName("leaderboards")]
        public Self Leaderboards { get; }

        /// <summary>
        /// Gets a link to PvP rewards.
        /// </summary>
        [JsonPropertyName("rewards")]
        public Self Rewards { get; }

        /// <summary>
        /// Gets the start timestamp of the PvP season.
        /// </summary>
        [JsonPropertyName("season_start_timestamp")]
        public DateTimeOffset SeasonStartTimestamp { get; }

        /// <summary>
        /// Gets the end timestamp of the PvP season.
        /// </summary>
        [JsonPropertyName("season_end_timestamp")]
        public DateTimeOffset SeasonEndTimestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpSeason"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP season.</param>
        /// <param name="id">The ID of the PvP season.</param>
        /// <param name="leaderboards">A link to PvP leaderboards.</param>
        /// <param name="rewards">A link to PvP rewards.</param>
        /// <param name="seasonStartTimestamp">The start timestamp of the PvP season.</param>
        /// <param name="seasonEndTimestamp">The end timestamp of the PvP season.</param>
        [JsonConstructor]
        public PvpSeason(Links links, int id, Self leaderboards, Self rewards, DateTimeOffset seasonStartTimestamp, DateTimeOffset seasonEndTimestamp)
        {
            Links = links;
            Id = id;
            Leaderboards = leaderboards;
            Rewards = rewards;
            SeasonStartTimestamp = seasonStartTimestamp;
            SeasonEndTimestamp = seasonEndTimestamp;
        }
    }
}
