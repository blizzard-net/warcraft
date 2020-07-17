using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievement aggregates by faction.
    /// </summary>
    public class AggregatesByFaction
    {
        /// <summary>
        /// Gets the aggregates for the Alliance.
        /// </summary>
        [JsonPropertyName("alliance")]
        public FactionAchievementAggregates Alliance { get; private set; }

        /// <summary>
        /// Gets the aggregates for the Horde.
        /// </summary>
        [JsonPropertyName("horde")]
        public FactionAchievementAggregates Horde { get; private set; }
    }
}
