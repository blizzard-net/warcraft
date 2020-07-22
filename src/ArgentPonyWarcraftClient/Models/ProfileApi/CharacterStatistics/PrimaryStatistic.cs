using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character statistic.
    /// </summary>
    public class PrimaryStatistic
    {
        /// <summary>
        /// Gets the base statistic.
        /// </summary>
        [JsonPropertyName("base")]
        public int Base { get; set; }

        /// <summary>
        /// Gets the effective statistic.
        /// </summary>
        [JsonPropertyName("effective")]
        public int Effective { get; set; }
    }
}
