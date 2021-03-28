using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A current period.
    /// </summary>
    public class CurrentPeriod
    {
        /// <summary>
        /// Gets a reference to the Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("period")]
        public MythicKeystonePeriodReference Period { get; set; }

        /// <summary>
        /// Gets the best runs during the current period.
        /// </summary>
        [JsonPropertyName("best_runs")]
        public MythicKeystoneRun[] BestRuns { get; set; }
    }
}
