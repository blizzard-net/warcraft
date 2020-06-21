using Newtonsoft.Json;

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
        [JsonProperty("upgrade_level")]
        public long UpgradeLevel { get; set; }

        /// <summary>
        /// Gets the qualifying duration.
        /// </summary>
        [JsonProperty("qualifying_duration")]
        public long QualifyingDuration { get; set; }
    }
}
