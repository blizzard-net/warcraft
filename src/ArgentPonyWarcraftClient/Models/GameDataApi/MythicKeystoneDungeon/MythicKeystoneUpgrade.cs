using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone upgrade.
    /// </summary>
    public class MythicKeystoneUpgrade
    {
        /// <summary>
        /// Gets the upgrade level.
        /// </summary>
        [JsonPropertyName("upgrade_level")]
        public long UpgradeLevel { get; set; }

        /// <summary>
        /// Gets the qualifying duration.
        /// </summary>
        [JsonPropertyName("qualifying_duration")]
        public long QualifyingDuration { get; set; }
    }
}
