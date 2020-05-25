using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// Gets a spell associated with an item.
    /// </summary>
    public class ItemSpell
    {
        /// <summary>
        /// Gets a reference to a spell.
        /// </summary>
        [JsonProperty("spell")]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets the description of the spell.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
