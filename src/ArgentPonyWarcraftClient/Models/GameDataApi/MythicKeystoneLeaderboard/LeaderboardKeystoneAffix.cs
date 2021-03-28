using System.Text.Json.Serialization;

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
        [JsonPropertyName("keystone_affix")]
        public MythicKeystoneAffixReference KeystoneAffix { get; set; }

        /// <summary>
        /// Gets the starting level for the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("starting_level")]
        public int StartingLevel { get; set; }
    }
}
