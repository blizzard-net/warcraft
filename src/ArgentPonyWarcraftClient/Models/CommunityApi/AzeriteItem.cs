using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An Azerite item.
    /// </summary>
    public class AzeriteItem
    {
        /// <summary>
        /// Gets or sets the Azerite level.
        /// </summary>
        [JsonProperty("azeriteLevel")]
        public int AzeriteLevel { get; set; }

        /// <summary>
        /// Gets or sets the current Azerite experience.
        /// </summary>
        [JsonProperty("azeriteExperience")]
        public int AzeriteExperience { get; set; }

        /// <summary>
        /// Gets or sets the Azerite experience remaining to the next level.
        /// </summary>
        [JsonProperty("azeriteExperienceRemaining")]
        public int AzeriteExperienceRemaining { get; set; }
    }
}
