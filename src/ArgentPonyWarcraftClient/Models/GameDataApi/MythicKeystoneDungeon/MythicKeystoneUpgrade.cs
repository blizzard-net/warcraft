using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone upgrade.
    /// </summary>
    public record MythicKeystoneUpgrade
    {
        /// <summary>
        /// Gets the upgrade level.
        /// </summary>
        [JsonPropertyName("upgrade_level")]
        public int UpgradeLevel { get; }

        /// <summary>
        /// Gets the qualifying duration.
        /// </summary>
        [JsonPropertyName("qualifying_duration")]
        public TimeSpan QualifyingDuration { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneUpgrade"/> class.
        /// </summary>
        /// <param name="upgradeLevel">The upgrade level.</param>
        /// <param name="qualifyingDuration">The qualifying duration.</param>
        [JsonConstructor]
        public MythicKeystoneUpgrade(int upgradeLevel, TimeSpan qualifyingDuration)
        {
            UpgradeLevel = upgradeLevel;
            QualifyingDuration = qualifyingDuration;
        }
    }
}
