using Newtonsoft.Json;

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
        [JsonProperty("alliance")]
        public FactionAchievementAggregates Alliance { get; private set; }

        /// <summary>
        /// Gets the aggregates for the Horde.
        /// </summary>
        [JsonProperty("horde")]
        public FactionAchievementAggregates Horde { get; private set; }
    }
}
