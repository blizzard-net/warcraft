using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP seasons.
    /// </summary>
    public class PvpSeasonsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP seasons.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the PvP seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public PvpSeasonReference[] Seasons { get; set; }

        /// <summary>
        /// Gets a reference to the current PvP season.
        /// </summary>
        [JsonPropertyName("current_season")]
        public PvpSeasonReference CurrentSeason { get; set; }
    }
}
