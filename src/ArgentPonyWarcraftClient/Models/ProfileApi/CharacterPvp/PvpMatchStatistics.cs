using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP match statistics.
    /// </summary>
    public class PvpMatchStatistics
    {
        /// <summary>
        /// Gets the number of matches played.
        /// </summary>
        [JsonPropertyName("played")]
        public long Played { get; set; }

        /// <summary>
        /// Gets the number of matches won.
        /// </summary>
        [JsonPropertyName("won")]
        public long Won { get; set; }

        /// <summary>
        /// Gets the number of matches lost.
        /// </summary>
        [JsonPropertyName("lost")]
        public long Lost { get; set; }
    }
}
