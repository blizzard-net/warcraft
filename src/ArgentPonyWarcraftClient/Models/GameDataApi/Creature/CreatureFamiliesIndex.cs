using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of creature families.
    /// </summary>
    public class CreatureFamiliesIndex
    {
        /// <summary>
        /// Gets links for the index of creature families.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the creature families.
        /// </summary>
        [JsonProperty("creature_families")]
        public CreatureFamilyReference[] CreatureFamilies { get; set; }
    }
}
