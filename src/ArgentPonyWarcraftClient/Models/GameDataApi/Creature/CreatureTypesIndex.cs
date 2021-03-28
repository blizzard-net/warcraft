using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of creature types.
    /// </summary>
    public record CreatureTypesIndex
    {
        /// <summary>
        /// Gets links for the index of creature types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the creature types.
        /// </summary>
        [JsonPropertyName("creature_types")]
        public CreatureTypeReference[] CreatureTypes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureTypesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of creature types.</param>
        /// <param name="creatureTypes">References to the creature types.</param>
        [JsonConstructor]
        public CreatureTypesIndex(Links links, CreatureTypeReference[] creatureTypes)
        {
            Links = links;
            CreatureTypes = creatureTypes;
        }
    }
}
