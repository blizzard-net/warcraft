using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the items equipped by a character.
    /// </summary>
    public class CharacterEquipmentSummary
    {
        /// <summary>
        /// Gets links for the character equipment summary.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's equipped items.
        /// </summary>
        [JsonPropertyName("equipped_items")]
        public EquippedItem[] EquippedItems { get; set; }
    }
}
