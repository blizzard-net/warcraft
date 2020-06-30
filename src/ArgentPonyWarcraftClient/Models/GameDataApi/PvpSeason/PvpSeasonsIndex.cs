using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the PvP seasons.
        /// </summary>
        [JsonProperty("seasons")]
        public PvpSeasonReference[] Seasons { get; set; }

        /// <summary>
        /// Gets a reference to the current PvP season.
        /// </summary>
        [JsonProperty("current_season")]
        public PvpSeasonReference CurrentSeason { get; set; }
    }
}
