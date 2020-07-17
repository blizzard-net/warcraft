using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone periods.
    /// </summary>
    public class MythicKeystonePeriodsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone periods.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mythic keystone periods.
        /// </summary>
        [JsonPropertyName("periods")]
        public MythicKeystonePeriodReference[] Periods { get; set; }

        /// <summary>
        /// Gets a reference to the current mythic keystone period.
        /// </summary>
        [JsonPropertyName("current_period")]
        public MythicKeystonePeriodReference CurrentPeriod { get; set; }
    }
}
