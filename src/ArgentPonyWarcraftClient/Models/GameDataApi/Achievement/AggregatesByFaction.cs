using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievement aggregates by faction.
    /// </summary>
    public record AggregatesByFaction
    {
        /// <summary>
        /// Gets the aggregates for the Alliance.
        /// </summary>
        [JsonPropertyName("alliance")]
        public FactionAchievementAggregates Alliance { get; }

        /// <summary>
        /// Gets the aggregates for the Horde.
        /// </summary>
        [JsonPropertyName("horde")]
        public FactionAchievementAggregates Horde { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatesByFaction"/> class.
        /// </summary>
        /// <param name="alliance">The aggregates for the Alliance.</param>
        /// <param name="horde">The aggregates for the Horde.</param>
        [JsonConstructor]
        public AggregatesByFaction(FactionAchievementAggregates alliance, FactionAchievementAggregates horde)
        {
            Alliance = alliance;
            Horde = horde;
        }
    }
}
