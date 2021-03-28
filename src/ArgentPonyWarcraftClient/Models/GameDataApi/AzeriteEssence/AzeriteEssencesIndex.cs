using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of azerite essences.
    /// </summary>
    public record AzeriteEssencesIndex
    {
        /// <summary>
        /// Gets links for the index of azerite essences.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the azerite essences.
        /// </summary>
        [JsonPropertyName("azerite_essences")]
        public AzeriteEssenceReference[] AzeriteEssences { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzeriteEssencesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of azerite essences.</param>
        /// <param name="azeriteEssences">References to the azerite essences.</param>
        [JsonConstructor]
        public AzeriteEssencesIndex(Links links, AzeriteEssenceReference[] azeriteEssences)
        {
            Links = links;
            AzeriteEssences = azeriteEssences;
        }
    }
}
