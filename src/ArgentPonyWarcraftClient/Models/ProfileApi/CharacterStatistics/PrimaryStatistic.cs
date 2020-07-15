using Newtonsoft.Json;

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
        [JsonProperty("base")]
        public long Base { get; set; }

        /// <summary>
        /// Gets the effective statistic.
        /// </summary>
        [JsonProperty("effective")]
        public long Effective { get; set; }
    }
}
