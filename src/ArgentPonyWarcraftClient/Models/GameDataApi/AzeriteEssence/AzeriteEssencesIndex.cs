using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the azerite essences.
        /// </summary>
        [JsonPropertyName("azerite_essences")]
        public AzeriteEssenceReference[] AzeriteEssences { get; set; }
    }
}
