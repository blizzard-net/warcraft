using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP match statistic for a character in a specific world map.
    /// </summary>
    public record PvpMapStatistic
    {
        /// <summary>
        /// Gets the world map.
        /// </summary>
        [JsonPropertyName("world_map")]
        public Map WorldMap { get; }

        /// <summary>
        /// Gets the character's PvP match statistics for the map.
        /// </summary>
        [JsonPropertyName("match_statistics")]
        public PvpMatchStatistics MatchStatistics { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpMapStatistic"/> class.
        /// </summary>
        /// <param name="worldMap">The world map.</param>
        /// <param name="matchStatistics">The character's PvP match statistics for the map.</param>
        [JsonConstructor]
        public PvpMapStatistic(Map worldMap, PvpMatchStatistics matchStatistics)
        {
            WorldMap = worldMap;
            MatchStatistics = matchStatistics;
        }
    }
}
