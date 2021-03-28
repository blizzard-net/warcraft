using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A current period.
    /// </summary>
    public record CurrentPeriod
    {
        /// <summary>
        /// Gets a reference to the Mythic Keystone period.
        /// </summary>
        [JsonPropertyName("period")]
        public MythicKeystonePeriodReference Period { get; }

        /// <summary>
        /// Gets the best runs during the current period.
        /// </summary>
        [JsonPropertyName("best_runs")]
        public MythicKeystoneRun[] BestRuns { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPeriod"/> class.
        /// </summary>
        /// <param name="period">A reference to the Mythic Keystone period.</param>
        /// <param name="bestRuns">The best runs during the current period.</param>
        [JsonConstructor]
        public CurrentPeriod(MythicKeystonePeriodReference period, MythicKeystoneRun[] bestRuns)
        {
            Period = period;
            BestRuns = bestRuns;
        }
    }
}
