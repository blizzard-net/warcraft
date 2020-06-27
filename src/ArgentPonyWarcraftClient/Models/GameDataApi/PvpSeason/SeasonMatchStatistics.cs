using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP season match statistics.
    /// </summary>
    public class SeasonMatchStatistics
    {
        /// <summary>
        /// Gets the number of matches played.
        /// </summary>
        [JsonProperty("played")]
        public long Played { get; set; }

        /// <summary>
        /// Gets the number of matches won.
        /// </summary>
        [JsonProperty("won")]
        public long Won { get; set; }

        /// <summary>
        /// Gets the number of matches lost.
        /// </summary>
        [JsonProperty("lost")]
        public long Lost { get; set; }
    }
}
