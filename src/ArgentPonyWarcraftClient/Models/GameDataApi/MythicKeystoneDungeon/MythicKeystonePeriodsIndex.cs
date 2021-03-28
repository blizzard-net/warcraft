using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone periods.
    /// </summary>
    public record MythicKeystonePeriodsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone periods.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the mythic keystone periods.
        /// </summary>
        [JsonPropertyName("periods")]
        public MythicKeystonePeriodReference[] Periods { get; }

        /// <summary>
        /// Gets a reference to the current mythic keystone period.
        /// </summary>
        [JsonPropertyName("current_period")]
        public MythicKeystonePeriodReference CurrentPeriod { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystonePeriodsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of mythic keystone periods.</param>
        /// <param name="periods">References to the mythic keystone periods.</param>
        /// <param name="currentPeriod">A reference to the current mythic keystone period.</param>
        [JsonConstructor]
        public MythicKeystonePeriodsIndex(Links links, MythicKeystonePeriodReference[] periods, MythicKeystonePeriodReference currentPeriod)
        {
            Links = links;
            Periods = periods;
            CurrentPeriod = currentPeriod;
        }
    }
}
