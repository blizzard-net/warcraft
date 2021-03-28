using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP seasons.
    /// </summary>
    public record PvpSeasonsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP seasons.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the PvP seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public PvpSeasonReference[] Seasons { get; }

        /// <summary>
        /// Gets a reference to the current PvP season.
        /// </summary>
        [JsonPropertyName("current_season")]
        public PvpSeasonReference CurrentSeason { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpSeasonsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of PvP seasons.</param>
        /// <param name="seasons">References to the PvP seasons.</param>
        /// <param name="currentSeason">A reference to the current PvP season.</param>
        [JsonConstructor]
        public PvpSeasonsIndex(Links links, PvpSeasonReference[] seasons, PvpSeasonReference currentSeason)
        {
            Links = links;
            Seasons = seasons;
            CurrentSeason = currentSeason;
        }
    }
}
