using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone affix and starting level.
    /// </summary>
    public record LeaderboardKeystoneAffix
    {
        /// <summary>
        /// Gets a reference to a mythic keystone affix.
        /// </summary>
        [JsonPropertyName("keystone_affix")]
        public MythicKeystoneAffixReference KeystoneAffix { get; }

        /// <summary>
        /// Gets the starting level for the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("starting_level")]
        public int StartingLevel { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardKeystoneAffix"/> class.
        /// </summary>
        /// <param name="keystoneAffix">A reference to a mythic keystone affix.</param>
        /// <param name="startingLevel">The starting level for the mythic keystone affix.</param>
        [JsonConstructor]
        public LeaderboardKeystoneAffix(MythicKeystoneAffixReference keystoneAffix, int startingLevel)
        {
            KeystoneAffix = keystoneAffix;
            StartingLevel = startingLevel;
        }
    }
}
