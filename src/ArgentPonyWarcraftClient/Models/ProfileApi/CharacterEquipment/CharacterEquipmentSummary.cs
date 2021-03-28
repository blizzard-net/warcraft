using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the items equipped by a character.
    /// </summary>
    public record CharacterEquipmentSummary
    {
        /// <summary>
        /// Gets links for the character equipment summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the character's equipped items.
        /// </summary>
        [JsonPropertyName("equipped_items")]
        public EquippedItem[] EquippedItems { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEquipmentSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the character equipment summary.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="equippedItems">The character's equipped items.</param>
        [JsonConstructor]
        public CharacterEquipmentSummary(Links links, CharacterReference character, EquippedItem[] equippedItems)
        {
            Links = links;
            Character = character;
            EquippedItems = equippedItems;
        }
    }
}
