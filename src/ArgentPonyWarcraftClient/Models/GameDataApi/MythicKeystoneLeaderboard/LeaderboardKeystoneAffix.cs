using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone affix and starting level.
    /// </summary>
    public class LeaderboardKeystoneAffix
    {
        /// <summary>
        /// Gets a reference to a mythic keystone affix.
        /// </summary>
        [JsonProperty("keystone_affix")]
        public MythicKeystoneAffixReference KeystoneAffix { get; set; }

        /// <summary>
        /// Gets the starting level for the mythic keystone affix.
        /// </summary>
        [JsonProperty("starting_level")]
        public long StartingLevel { get; set; }
    }
}
