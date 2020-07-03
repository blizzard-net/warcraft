using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of azerite essences.
    /// </summary>
    public class AzeriteEssencesIndex
    {
        /// <summary>
        /// Gets links for the index of azerite essences.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the azerite essences.
        /// </summary>
        [JsonProperty("azerite_essences")]
        public AzeriteEssenceReference[] AzeriteEssences { get; set; }
    }
}
