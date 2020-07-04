using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's equipped items.
        /// </summary>
        [JsonProperty("equipped_items")]
        public EquippedItem[] EquippedItems { get; set; }
    }
}
