using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of creature families.
    /// </summary>
    public record CreatureFamiliesIndex
    {
        /// <summary>
        /// Gets links for the index of creature families.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the creature families.
        /// </summary>
        [JsonPropertyName("creature_families")]
        public CreatureFamilyReference[] CreatureFamilies { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureFamiliesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of creature families.</param>
        /// <param name="creatureFamilies">References to the creature families.</param>
        [JsonConstructor]
        public CreatureFamiliesIndex(Links links, CreatureFamilyReference[] creatureFamilies)
        {
            Links = links;
            CreatureFamilies = creatureFamilies;
        }
    }
}
